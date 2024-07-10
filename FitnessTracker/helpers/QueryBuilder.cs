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
            string columns = string.Join(", ", parameters.Select(p => p.columnName));
            string values = string.Join(", ", parameters.Select(p => $"@{p.columnName}"));

            string query = $"INSERT INTO {env.DatabaseName}.{table} ({columns}) VALUES ({values}); SELECT LAST_INSERT_ID();";

            using (MySqlCommand command = new MySqlCommand(query, db.CONN))
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue($"@{parameter.columnName}", parameter.columnValue);
                }

                db.OpenConnection();
                int insertedId = Convert.ToInt32(command.ExecuteScalar());
                db.CloseConnection();

                return insertedId; // this means rows inserted successfully
            }
        }

        // Build SELECT command
        public static MySqlCommand BuildSelectCommand(string table, string selectedColumns = "*", (string columnName, object columnValue)[] conditions = null, string logicalOperator = "AND", int? limit = null, string orderByColumn = null, bool ascending = true, params string[] joinClauses)
        {
            MySqlCommand command = db.CONN.CreateCommand();
            StringBuilder queryBuilder = new StringBuilder($"SELECT {selectedColumns} FROM {env.DatabaseName}.{table}");

            AppendJoinClauses(queryBuilder, joinClauses);
            Where(command, queryBuilder, conditions, logicalOperator);
            OrderBy(queryBuilder, orderByColumn, ascending);
            Limit(queryBuilder, limit);
            command.CommandText = queryBuilder.ToString();
            return command;
        }

        // Read data with JOIN support
        public static MySqlDataReader Read(string table, string selectedColumns = "*", (string columnName, object columnValue)[] conditions = null, string logicalOperator = "AND", int? limit = null, string orderByColumn = null, bool ascending = true, params string[] joinClauses)
        {
            MySqlCommand command = BuildSelectCommand(table, selectedColumns, conditions, logicalOperator, limit, orderByColumn, ascending, joinClauses);
            db.OpenConnection();
            return command.ExecuteReader();
        }

        // Count rows
        public static int CountRows(string table, (string columnName, object columnValue)[] conditions = null)
        {
            int count = 0;
            using (MySqlCommand command = BuildSelectCommand(table, "COUNT(*)", conditions, "AND BINARY"))
            {
                db.OpenConnection();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    count = Convert.ToInt32(result);
                }
                db.CloseConnection();
            }
            return count;
        }

        // Update command with JOIN support
        public static int Update(string table, (string columnName, object columnValue)[] updateParameters, (string columnName, object columnValue)[] conditions = null, string logicalOperator = "AND")
        {

            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append($"UPDATE {env.DatabaseName}.{table} SET ");


            List<string> updateStrings = new List<string>();
            for (int i = 0; i < updateParameters.Length; i++)
            {
                string paramName = $"@updateValue{i}";
                updateStrings.Add($"{updateParameters[i].columnName} = {paramName}");
            }
            queryBuilder.Append(string.Join(", ", updateStrings));

            using (MySqlCommand command = new MySqlCommand())
            {

                Where(command, queryBuilder, conditions, logicalOperator);

                command.CommandText = queryBuilder.ToString();
                command.Connection = db.CONN;


                for (int i = 0; i < updateParameters.Length; i++)
                {
                    string paramName = $"@updateValue{i}";
                    command.Parameters.AddWithValue(paramName, updateParameters[i].columnValue);
                }

                db.OpenConnection();
                int rowsAffected = command.ExecuteNonQuery();
                db.CloseConnection();

                return rowsAffected;
            }
        }

        // Delete command with JOIN support
        public static void Delete(string table, (string columnName, object columnValue)[] conditions, params string[] joinClauses)
        {
            StringBuilder queryBuilder = new StringBuilder($"DELETE FROM {env.DatabaseName}.{table} ");

            AppendJoinClauses(queryBuilder, joinClauses);
            Where(null, queryBuilder, conditions);

            using (MySqlCommand command = new MySqlCommand(queryBuilder.ToString(), db.CONN))
            {
                foreach (var condition in conditions)
                {
                    command.Parameters.AddWithValue($"@{condition.columnName}", condition.columnValue);
                }



                db.OpenConnection();
                command.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        // Private methods
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
                    Console.WriteLine($"where {paramName}, {conditions[i].columnValue}");

                }
                Console.WriteLine(conditionStrings.ToArray());
                queryBuilder.Append(string.Join($" {logicalOperator} ", conditionStrings));
            }
        }

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

        private static void Limit(StringBuilder queryBuilder, int? limit)
        {
            if (limit.HasValue)
            {
                queryBuilder.Append($" LIMIT {limit}");
            }
        }

        private static void AppendJoinClauses(StringBuilder queryBuilder, string[] joinClauses)
        {
            foreach (var joinClause in joinClauses)
            {
                queryBuilder.Append($" {joinClause}");
            }
        }

    }
}
