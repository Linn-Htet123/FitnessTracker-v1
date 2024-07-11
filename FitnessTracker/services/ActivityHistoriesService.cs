﻿using FitnessTracker.enums;
using FitnessTracker.helpers;
using FitnessTracker.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FitnessTracker.services
{
    static internal class ActivityHistoriesService
    {
        private static readonly string ActivityHistoriesTable = Tables.ActivityHistories.ToTableName();
        private static readonly string ActivityTypesTable = Tables.ActivityTypes.ToTableName();
        private static readonly string JoinClause = $"JOIN {ActivityTypesTable} at ON ah.activity_type_id = at.id";
        private static readonly string SelectedColumns = "ah.*, at.activity_name, at.metric1_name, at.metric1_unit, at.metric2_name, at.metric2_unit, at.metric3_name, at.metric3_unit";

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
