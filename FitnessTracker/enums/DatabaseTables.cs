using System;

namespace FitnessTracker.enums
{
    public enum Tables
    {
        Users,
        Goals,
        ActivityTypes,
        ActivityHistories
    }

    public static class DatabaseTables
    {
        public static string ToTableName(this Tables table)
        {
            switch (table)
            {
                case Tables.Users:
                    return "users"; // Returns the table name "users" for the Users enum value
                case Tables.ActivityHistories:
                    return "activity_histories"; // Returns the table name "activity_histories" for the ActivityHistories enum value
                case Tables.Goals:
                    return "goals"; // Returns the table name "goals" for the Goals enum value
                case Tables.ActivityTypes:
                    return "activity_types"; // Returns the table name "activity_types" for the ActivityTypes enum value
                default:
                    throw new ArgumentOutOfRangeException(nameof(table), table, null); // Throws an exception for any unknown enum value
            }
        }
    }
}
