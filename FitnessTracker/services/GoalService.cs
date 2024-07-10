using FitnessTracker.enums;
using FitnessTracker.helpers;
using FitnessTracker.models;
using FitnessTracker.utils;
using System;
using System.Collections.Generic;
using static FitnessTracker.utils.ModalPopup;

namespace FitnessTracker.services
{
    internal static class GoalService
    {
        private static readonly string GoalsTable = Tables.Goals.ToTableName();

        // Create a new goal
        public static bool CreateGoal(int goalCalories, int userId)
        {
            return ErrorHandling.HandleError(() =>
            {
                var values = new (string columnName, object columnValue)[]
                {
                    ("goal_calories", goalCalories),
                    ("current_calories", 0),
                    ("user_id", userId),
                    ("created_at", DateTime.Now),
                    ("is_complete", false)
                };
                int insertedId = QueryBuilder.Insert(GoalsTable, values);
                return insertedId > 0;
            });
        }

        // Update current calories for a specific user's goal
        public static bool UpdateCurrentGoalCalories(int userId, int burnedCalories)
        {
            return ErrorHandling.HandleError(() =>
            {
                var latestGoal = GetGoalByUserId(userId);

                if (latestGoal == null)
                {
                    return false;
                }
                var totalBurnedCalories = latestGoal.CurrentCalories + burnedCalories;
                var updateValues = new (string columnName, object columnValue)[]
                {
                    ("current_calories",totalBurnedCalories),
                };

                var conditions = new (string columnName, object columnValue)[]
                {
                    ("id", latestGoal.GoalId),
                };


                QueryBuilder.Update(GoalsTable, updateValues, conditions);
                if (totalBurnedCalories >= latestGoal.GoalCalories)
                {
                    MarkGoalAsComplete(latestGoal.GoalId);
                    var completionStatus = Date.GetCompletionStatus(latestGoal.CreatedAt, DateTime.Now);

                    string message = $"Goal completed with calories of {totalBurnedCalories} ";
                    switch (completionStatus)
                    {
                        case GoalCompletionStatus.WithinOneDay:
                            message += "within one day!";
                            break;
                        case GoalCompletionStatus.WithinOneWeek:
                            message += " within one week.";
                            break;
                        case GoalCompletionStatus.MoreThanOneWeek:
                            message += "more than one week ago.";
                            break;
                        default:
                            break;
                    }

                    InfoPopup(message);
                }
                else
                {
                    InfoPopup($"You burned {burnedCalories} calories!");
                }

                return true;
            });
        }
        //mark as complete
        public static void MarkGoalAsComplete(int goalId)
        {
            ErrorHandling.HandleError(() =>
            {
                var updateValues = new (string columnName, object columnValue)[]
                {
                    ("is_complete", true),
                    ("completed_at", DateTime.Now)
                };

                var conditions = new (string columnName, object columnValue)[]
                {
                    ("id", goalId)
                };

                QueryBuilder.Update(GoalsTable, updateValues, conditions);
            });
        }
        // Retrieve all goals for a user
        public static List<Goal> GetGoalsForUser(int userId)
        {
            return ErrorHandling.HandleError(() =>
            {
                var conditions = new (string columnName, object columnValue)[]
                {
                    ("user_id", userId)
                };

                List<Goal> goals = new List<Goal>();

                using (var reader = QueryBuilder.Read(GoalsTable, conditions: conditions))
                {
                    while (reader.Read())
                    {
                        goals.Add(new Goal(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToInt32(reader["goal_calories"]),
                            Convert.ToInt32(reader["current_calories"]),
                            Convert.ToInt32(reader["user_id"]),
                            Convert.ToDateTime(reader["created_at"]),
                            Convert.ToBoolean(reader["is_complete"])
                        ));
                    }
                }

                return goals;
            });
        }

        // Calculate total calories burned by user through goals
        public static double GetTotalCaloriesBurnedByUser(int userId)
        {
            return ErrorHandling.HandleError(() =>
            {
                double totalCaloriesBurned = 0;
                var goals = GetGoalsForUser(userId);
                foreach (var goal in goals)
                {
                    totalCaloriesBurned += goal.CurrentCalories;
                }

                return totalCaloriesBurned;
            });
        }

        // Retrieve the latest goal for a user
        public static Goal GetGoalByUserId(int userId)
        {
            return ErrorHandling.HandleError(() =>
            {
                var conditions = new (string columnName, object columnValue)[]
                {
                    ("user_id", userId),
                };
                Console.WriteLine($"userID: {userId}");

                using (var reader = QueryBuilder.Read(GoalsTable, conditions: conditions, orderByColumn: "created_at", ascending: false, limit: 1))
                {
                    if (reader.Read())
                    {
                        return new Goal(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToInt32(reader["goal_calories"]),
                            Convert.ToInt32(reader["current_calories"]),
                            Convert.ToInt32(reader["user_id"]),
                            Convert.ToDateTime(reader["created_at"]),
                            Convert.ToBoolean(reader["is_complete"])
                        );
                    }
                }

                return null;
            });
        }

        // Check if a user has incomplete goals
        public static bool HasIncompleteGoalsForUser(int userId)
        {
            return ErrorHandling.HandleError(() =>
            {
                var conditions = new (string columnName, object columnValue)[]
                {
                    ("user_id", userId),
                    ("is_complete", false)
                };

                return QueryBuilder.CountRows(GoalsTable, conditions) > 0;
            });
        }
    }
}
