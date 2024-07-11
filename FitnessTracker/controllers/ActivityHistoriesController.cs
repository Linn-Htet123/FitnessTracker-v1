using FitnessTracker.models;
using FitnessTracker.services;
using System.Collections.Generic;
using static FitnessTracker.services.ActivityHistoriesService;


namespace FitnessTracker.controllers
{
    internal class ActivityHistoriesController
    {
        readonly int userId = StoreServices.GetState<User>("CurrentUser").UserId;
        public bool CreateActivityHistories(int activityTypeId, double burnedCalories)
        {
            return CreateActivity(userId, activityTypeId, burnedCalories);
        }

        public List<Dictionary<string, object>> GetActivityHistoriesByUser()
        {
            return GetActivityHistoriesByUserId(userId);
        }
    }
}
