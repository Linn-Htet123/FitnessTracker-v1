using FitnessTracker.enums;
using FitnessTracker.helpers;
using FitnessTracker.models;
using MySql.Data.MySqlClient;

namespace FitnessTracker.services
{
    internal static class ActivityTypeService
    {
        private static readonly string ActivityTypesTable = Tables.ActivityTypes.ToTableName();

        // Retrieve an ActivityType object by activity name
        public static ActivityType GetActivityTypeByName(ActivityTypesEnum activityName)
        {
            // Convert ActivityTypesEnum to string activity name
            string activityNameString = activityName.ToActivityName();

            // Define conditions to query by activity_name
            var conditions = new (string columnName, object columnValue)[]
            {
                ("activity_name", activityNameString)
            };

            // Execute query and read the result
            using (MySqlDataReader reader = QueryBuilder.Read(ActivityTypesTable, conditions: conditions))
            {
                if (reader.Read())
                {
                    // Map reader data to ActivityType object
                    return new ActivityType
                    (
                        reader.GetInt32("id"),
                        reader.GetString("activity_name"),
                        reader.GetString("metric1_name"),
                        reader.GetString("metric1_unit"),
                        reader.GetString("metric2_name"),
                        reader.GetString("metric2_unit"),
                        reader.GetString("metric3_name"),
                        reader.GetString("metric3_unit")
                    );
                }

                return null; // Return null if no activity type found
            }
        }
    }
}
