using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessTracker.helpers
{
    internal static class QueryBuilder
    {
        private static readonly ConnectDB db = new ConnectDB();
        private static readonly Env env = new Env();

        // Insert command
        public static int Insert(string table, params (string columnName, object columnValue)[] parameters)
        {
            // Build column names and parameter placeholders
            string columns = string.Join(", ", parameters.Select(p => p.columnName));
            string values = string.Join(", ", parameters.Select(p => $"@{p.columnName}"));

            // Construct SQL query for insertion
            string query = $"INSERT INTO {env.DatabaseName}.{table} ({columns}) VALUES ({values}); SELECT LAST_INSERT_ID();";

            // Execute the command
            using (MySqlCommand command = new MySqlCommand(query, db.CONN))
            {
                // Add parameters to the command
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue($"@{parameter.columnName}", parameter.columnValue);
                }

                // Open database connection, execute the query, and retrieve inserted ID
                db.OpenConnection();
                int insertedId = Convert.ToInt32(command.ExecuteScalar());
                db.CloseConnection();

                return insertedId; // Return the ID of the last inserted row
            }
        }

        // Build SELECT command with JOIN support
        public static MySqlCommand BuildSelectCommand(string table, string selectedColumns = "*", (string columnName, object columnValue)[] conditions = null, string logicalOperator = "AND", int? limit = null, string orderByColumn = null, bool ascending = true, string[] joinClauses = null, string[] groupByColumns = null)
        {
            MySqlCommand command = db.CONN.CreateCommand();
            StringBuilder queryBuilder = new StringBuilder($"SELECT {selectedColumns} FROM {env.DatabaseName}.{table}");

            // Append JOIN clauses if specified
            Join(queryBuilder, joinClauses);

            // Append WHERE clauses if specified
            Where(command, queryBuilder, conditions, logicalOperator);

            // Append GROUP BY clause if specified
            GroupBy(queryBuilder, groupByColumns);

            // Append ORDER BY clause if specified
            OrderBy(queryBuilder, orderByColumn, ascending);

            // Append LIMIT clause if specified
            Limit(queryBuilder, limit);

            // Set the query to the MySqlCommand object
            command.CommandText = queryBuilder.ToString();
            return command;
        }

        // Execute SELECT query and return MySqlDataReader
        public static MySqlDataReader Read(string table, string selectedColumns = "*", (string columnName, object columnValue)[] conditions = null, string logicalOperator = "AND", int? limit = null, string orderByColumn = null, bool ascending = true, string[] joinClauses = null, string[] groupByColumns = null)
        {
            MySqlCommand command = BuildSelectCommand(table, selectedColumns, conditions, logicalOperator, limit, orderByColumn, ascending, joinClauses, groupByColumns);

            // Open database connection and execute the query
            db.OpenConnection();
            return command.ExecuteReader();
        }

        // Count rows in a table with optional conditions
        public static int CountRows(string table, (string columnName, object columnValue)[] conditions = null)
        {
            int count = 0;
            using (MySqlCommand command = BuildSelectCommand(table, "COUNT(*)", conditions, "AND BINARY"))
            {
                // Open database connection, execute scalar query to get count, and close connection
                db.OpenConnection();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    count = Convert.ToInt32(result);
                }
                db.CloseConnection();
            }
            return count; // Return the count of rows
        }

        // Update rows in a table with optional JOIN and WHERE clauses
        public static int Update(string table, (string columnName, object columnValue)[] updateParameters, (string columnName, object columnValue)[] conditions = null, string logicalOperator = "AND", params string[] joinClauses)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append($"UPDATE {env.DatabaseName}.{table}");

            // Append JOIN clauses if specified
            Join(queryBuilder, joinClauses);

            // Append SET clause with update parameters
            queryBuilder.Append(" SET ");
            List<string> updateStrings = new List<string>();
            for (int i = 0; i < updateParameters.Length; i++)
            {
                string paramName = $"@updateValue{i}";
                updateStrings.Add($"{updateParameters[i].columnName} = {paramName}");
            }
            queryBuilder.Append(string.Join(", ", updateStrings));

            // Execute UPDATE command
            using (MySqlCommand command = new MySqlCommand())
            {
                // Append WHERE clause if specified
                Where(command, queryBuilder, conditions, logicalOperator);

                // Set MySqlCommand properties
                command.CommandText = queryBuilder.ToString();
                command.Connection = db.CONN;

                // Add parameters to MySqlCommand
                for (int i = 0; i < updateParameters.Length; i++)
                {
                    string paramName = $"@updateValue{i}";
                    command.Parameters.AddWithValue(paramName, updateParameters[i].columnValue);
                }

                // Open database connection, execute query, retrieve rows affected, and close connection
                db.OpenConnection();
                int rowsAffected = command.ExecuteNonQuery();
                db.CloseConnection();

                return rowsAffected; // Return number of rows affected by the UPDATE
            }
        }

        // Delete rows from a table with optional JOIN and WHERE clauses
        public static void Delete(string table, (string columnName, object columnValue)[] conditions, params string[] joinClauses)
        {
            StringBuilder queryBuilder = new StringBuilder($"DELETE FROM {env.DatabaseName}.{table}");

            // Append JOIN clauses if specified
            Join(queryBuilder, joinClauses);

            // Append WHERE clause with conditions
            Where(null, queryBuilder, conditions);

            // Execute DELETE command
            using (MySqlCommand command = new MySqlCommand(queryBuilder.ToString(), db.CONN))
            {
                // Add parameters to MySqlCommand for WHERE clause
                foreach (var condition in conditions)
                {
                    command.Parameters.AddWithValue($"@{condition.columnName}", condition.columnValue);
                }

                // Open database connection, execute DELETE query, and close connection
                db.OpenConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        // Private helper methods

        // Append JOIN clauses to queryBuilder
        private static void Join(StringBuilder queryBuilder, params string[] joinClauses)
        {
            if (joinClauses != null && joinClauses.Length > 0)
            {
                foreach (var joinClause in joinClauses)
                {
                    queryBuilder.Append(" ").Append(joinClause);
                }
            }
        }

        // Append WHERE clause to queryBuilder with conditions
        private static void Where(MySqlCommand command, StringBuilder queryBuilder, (string columnName, object columnValue)[] conditions, string logicalOperator = "AND")
        {
            if (conditions != null && conditions.Length > 0)
            {
                queryBuilder.Append(" WHERE ");
                List<string> conditionStrings = new List<string>();

                for (int i = 0; i < conditions.Length; i++)
                {
                    string paramName = $"@value{i}";
                    conditionStrings.Add($"{conditions[i].columnName} = {paramName}");
                    command.Parameters.AddWithValue(paramName, conditions[i].columnValue);
                }
                queryBuilder.Append(string.Join($" {logicalOperator} ", conditionStrings));
            }
        }

        // Append WHERE clause to queryBuilder with conditions and custom comparison operators
        private static void Where(MySqlCommand command, StringBuilder queryBuilder, (string columnName, object columnValue, string comparisonOperator)[] conditions, string logicalOperator = "AND")
        {
            if (conditions != null && conditions.Length > 0)
            {
                queryBuilder.Append(" WHERE ");
                List<string> conditionStrings = new List<string>();

                for (int i = 0; i < conditions.Length; i++)
                {
                    string paramName = $"@value{i}";
                    string operatorSymbol = conditions[i].comparisonOperator ?? "="; // Default to '=' if operator is null
                    conditionStrings.Add($"{conditions[i].columnName} {operatorSymbol} {paramName}");
                    command.Parameters.AddWithValue(paramName, conditions[i].columnValue);
                }
                queryBuilder.Append(string.Join($" {logicalOperator} ", conditionStrings));
            }
        }

        // Append ORDER BY clause to queryBuilder
        private static void OrderBy(StringBuilder queryBuilder, string orderByColumn, bool ascending = false)
        {
            if (!string.IsNullOrEmpty(orderByColumn))
            {
                queryBuilder.Append($" ORDER BY {orderByColumn}");

                if (!ascending)
                {
                    queryBuilder.Append(" DESC");
                }
            }
        }

        // Append LIMIT clause to queryBuilder
        private static void Limit(StringBuilder queryBuilder, int? limit)
        {
            if (limit.HasValue)
            {
                queryBuilder.Append($" LIMIT {limit}");
            }
        }

        // Append GROUP BY clause to queryBuilder
        private static void GroupBy(StringBuilder queryBuilder, string[] groupByColumns)
        {
            if (groupByColumns != null && groupByColumns.Length > 0)
            {
                queryBuilder.Append(" GROUP BY ");
                queryBuilder.Append(string.Join(", ", groupByColumns));
            }
        }
    }
}
