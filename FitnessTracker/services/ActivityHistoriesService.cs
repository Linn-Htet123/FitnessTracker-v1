using FitnessTracker.enums;
using FitnessTracker.helpers;
using FitnessTracker.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FitnessTracker.services
{
    static internal class ActivityHistoriesService
    {
        private static readonly ConnectDB db = new ConnectDB();
        private static readonly string ActivityHistoriesTable = Tables.ActivityHistories.ToTableName();
        private static readonly string ActivityTypesTable = Tables.ActivityTypes.ToTableName();
        private static readonly string JoinClause = $"JOIN {ActivityTypesTable} at ON ah.activity_type_id = at.id";
        private static readonly string SelectedColumns = "ah.*, at.activity_name, at.metric1_name, at.metric1_unit, at.metric2_name, at.metric2_unit, at.metric3_name, at.metric3_unit";

        // Create an activity history record for a user
        public static bool CreateActivity(int userId, int activityTypeId, double burnedCalories)
        {
            return ErrorHandling.HandleError(() =>
            {
                var values = new (string columnName, object columnValue)[]
                {
                    ("user_id", userId),
                    ("activity_type_id", activityTypeId),
                    ("burned_calories", burnedCalories),
                    ("created_at", DateTime.Now)
                };

                int insertedId = QueryBuilder.Insert(ActivityHistoriesTable, values);
                return insertedId > 0;
            });
        }

        // Retrieve detailed activity history by ID
        public static ActivityHistoriesDetails GetActivityHistoryDetailById(int id)
        {
            return ErrorHandling.HandleError(() =>
            {
                var conditions = new (string columnName, object columnValue)[] { ("ah.id", id) };

                using (MySqlDataReader reader = QueryBuilder.Read(ActivityHistoriesTable + " ah", SelectedColumns, conditions, joinClauses: new string[] { JoinClause }))
                {
                    return reader.Read() ? MapActivityHistoryDetails(reader) : null;
                }
            });
        }

        // Retrieve all activity histories for a user
        public static List<Dictionary<string, object>> GetActivityHistoriesByUserId(int userId)
        {
            List<Dictionary<string, object>> activityHistories = new List<Dictionary<string, object>>();
            var conditions = new (string columnName, object columnValue)[] { ("ah.user_id", userId) };
            using (MySqlDataReader reader = QueryBuilder.Read(ActivityHistoriesTable + " ah", SelectedColumns, conditions, orderByColumn: "ah.created_at", ascending: false, joinClauses: new string[] { JoinClause }))
            {
                while (reader.Read())
                {
                    activityHistories.Add(MapReaderToDictionary(reader));
                }
            }

            return activityHistories;
        }

        // Retrieve counts of activities by type for a user
        public static Dictionary<string, int> GetActivityCountsByUserId(int userId)
        {
            return ErrorHandling.HandleError(() =>
            {
                Dictionary<string, int> activityCounts = new Dictionary<string, int>();
                foreach (ActivityTypesEnum activityType in Enum.GetValues(typeof(ActivityTypesEnum)))
                {
                    activityCounts[activityType.ToActivityName()] = 0;
                }

                foreach (ActivityTypesEnum activityType in Enum.GetValues(typeof(ActivityTypesEnum)))
                {
                    var conditions = new (string columnName, object columnValue)[]
                    {
                        ("user_id", userId),
                    };

                    using (MySqlDataReader reader = QueryBuilder.Read(
                        ActivityHistoriesTable + " ah",
                        "COUNT(*) as count, at.activity_name",
                        conditions,
                        joinClauses: new string[] { JoinClause },
                        groupByColumns: new string[] { "ah.activity_type_id", "at.activity_name" }
                    ))
                    {
                        while (reader.Read())
                        {
                            string activityName = reader.GetString("activity_name");
                            int count = reader.GetInt32("count");
                            activityCounts[activityName] = count;
                        }
                    }
                }

                return activityCounts;
            });
        }

        // Private method: Map data from MySqlDataReader to ActivityHistoriesDetails object
        private static ActivityHistoriesDetails MapActivityHistoryDetails(MySqlDataReader reader)
        {
            return new ActivityHistoriesDetails(
                reader.GetInt32("id"),
                reader.GetInt32("activity_type_id"),
                reader.GetInt32("user_id"),
                reader.GetDouble("burned_calories"),
                reader.GetDateTime("created_at"),
                reader.GetString("activity_name"),
                reader.GetString("metric1_name"),
                reader.GetString("metric1_unit"),
                reader.GetString("metric2_name"),
                reader.GetString("metric2_unit"),
                reader.GetString("metric3_name"),
                reader.GetString("metric3_unit")
            );
        }

        // Retrieve total calories burned for a specific date range
        private static double GetTotalCaloriesBurnedForDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            double totalCaloriesBurned = 0;

            // Construct the SQL query string
            string query = $"SELECT SUM(burned_calories) AS totalCalories FROM fitness_tracker.activity_histories " +
                           $"WHERE user_id = @userId AND created_at >= @startDate AND created_at <= @endDate";

            MySqlCommand command = new MySqlCommand(query, db.CONN);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"));

            try
            {
                db.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        totalCaloriesBurned = reader.IsDBNull(0) ? 0 : reader.GetDouble("totalCalories");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing SQL query: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }

            return totalCaloriesBurned;
        }

        // Retrieve total calories burned today for a user
        public static double GetTotalCaloriesBurnedToday(int userId)
        {
            return ErrorHandling.HandleError(() =>
            {
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);
                return GetTotalCaloriesBurnedForDateRange(userId, today, tomorrow);
            });
        }

        // Retrieve total calories burned within a specific date range for a user
        public static double GetTotalCaloriesBurnedByDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            return ErrorHandling.HandleError(() =>
            {
                return GetTotalCaloriesBurnedForDateRange(userId, startDate, endDate);
            });
        }

        // Private method: Map data from MySqlDataReader to Dictionary<string, object>
        private static Dictionary<string, object> MapReaderToDictionary(MySqlDataReader reader)
        {
            Dictionary<string, object> activityHistory = new Dictionary<string, object>();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                activityHistory[reader.GetName(i)] = reader.GetValue(i);
            }

            return activityHistory;
        }
    }
}
