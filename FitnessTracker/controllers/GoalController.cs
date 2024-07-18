using FitnessTracker.models;
using FitnessTracker.services;
using static FitnessTracker.services.GoalService;

namespace FitnessTracker.controllers
{
    internal class GoalController
    {
        readonly int userId = StoreServices.GetState<User>("CurrentUser").UserId; // Fetches the current user's ID from the state
        public bool Create(int calories_goal)
        {
            return CreateGoal(calories_goal, userId); // Creates a new goal for the user with the specified calorie goal
        }

        public bool HasIncompleteGoal()
        {
            return HasIncompleteGoalsForUser(userId); // Checks if the user has any incomplete goals
        }

        public Goal GetCurrentGoal()
        {
            return GetGoalByUserId(userId); // Retrieves the current goal for the user
        }

        public double GetTotalCaloriesBurned()
        {
            return GetTotalCaloriesBurnedByUser(userId); // Retrieves the total calories burned by the user
        }

        public bool UpdateCurrentCalories(int burnedCalories)
        {
            return UpdateCurrentGoalCalories(userId, burnedCalories); // Updates the current goal's calories burned for the user
        }

        public int GetTotalAchievementGoals()
        {
            return GetTotalAchievementGoalsByUser(userId); // Retrieves the total number of achieved goals by the user
        }
    }
}
