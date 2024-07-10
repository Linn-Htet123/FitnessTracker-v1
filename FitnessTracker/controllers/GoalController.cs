using FitnessTracker.models;
using FitnessTracker.services;
using static FitnessTracker.services.GoalService;
namespace FitnessTracker.controllers
{
    internal class GoalController
    {
        readonly int userId = StoreServices.GetState<User>("CurrentUser").UserId;
        public bool Create(int calories_goal)
        {
            return CreateGoal(calories_goal, userId);
        }

        public bool HasIncompleteGoal()
        {
            return HasIncompleteGoalsForUser(userId);
        }

        public Goal GetCurrentGoal()
        {
            return GetGoalByUserId(userId);
        }

        public double GetTotalCaloriesBurned()
        {
            return GetTotalCaloriesBurnedByUser(userId);
        }

        public bool UpdateCurrentCalories(int burnedCalories)
        {
            return UpdateCurrentGoalCalories(userId, burnedCalories);
        }
    }
}
