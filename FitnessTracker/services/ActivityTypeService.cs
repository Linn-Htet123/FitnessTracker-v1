using FitnessTracker.enums;
using FitnessTracker.helpers;
using FitnessTracker.models;
using MySql.Data.MySqlClient;

namespace FitnessTracker.services
{
    internal static class ActivityTypeService
    {
        private static readonly string ActivityTypesTable = Tables.ActivityTypes.ToTableName();

        public static ActivityType GetActivityTypeByName(ActivityTypesEnum activityName)
        {
            string activityNameString = activityName.ToActivityName();

            var conditions = new (string columnName, object columnValue)[]
            {
                ("activity_name", activityNameString)
            };

            using (MySqlDataReader reader = QueryBuilder.Read(ActivityTypesTable, conditions: conditions))
            {
                if (reader.Read())
                {
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

                return null;
            }
        }
    }
}
