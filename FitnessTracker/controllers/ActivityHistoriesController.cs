using FitnessTracker.models;
using FitnessTracker.services;
using System;
using System.Collections.Generic;
using static FitnessTracker.services.ActivityHistoriesService;

namespace FitnessTracker.controllers
{
    internal class ActivityHistoriesController
    {
        readonly int userId = StoreServices.GetState<User>("CurrentUser").UserId; // Fetches the current user's ID from the state
        public bool CreateActivityHistories(int activityTypeId, double burnedCalories)
        {
            return CreateActivity(userId, activityTypeId, burnedCalories); // Creates a new activity history for the user
        }

        public List<Dictionary<string, object>> GetActivityHistoriesByUser()
        {
            return GetActivityHistoriesByUserId(userId); // Retrieves activity histories for the current user
        }

        public Dictionary<string, int> GetActivityCount()
        {
            return GetActivityCountsByUserId(userId); // Retrieves the count of different activities for the current user
        }

        public double GetDailyCaloriesBurned()
        {
            return GetTotalCaloriesBurnedToday(userId); // Retrieves the total calories burned by the user today
        }

        public double GetDateRangeCaloriesBurned(DateTime startDate, DateTime endDate)
        {
            return GetTotalCaloriesBurnedByDateRange(userId, startDate, endDate); // Retrieves the total calories burned by the user within a specified date range
        }
    }
}
