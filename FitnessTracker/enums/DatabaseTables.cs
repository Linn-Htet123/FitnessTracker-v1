﻿using System;

namespace FitnessTracker.enums
{
    public enum Tables
    {
        Users,
        Goals,
        ActivityTypes,
        Activityistories
    }

    public static class DatabaseTables
    {
        public static string ToTableName(this Tables table)
        {
            switch (table)
            {
                case Tables.Users:
                    return "users";
                case Tables.Activityistories:
                    return "activity_histories";
                case Tables.Goals:
                    return "goals";
                case Tables.ActivityTypes:
                    return "activity_types";

                default:
                    throw new ArgumentOutOfRangeException(nameof(table), table, null);
            }
        }
    }
}
