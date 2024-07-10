using FitnessTracker.models.interfaces;
using System;

namespace FitnessTracker.models
{
    public class Goal : IGoal
    {
        // Private fields to encapsulate the data
        private readonly int goal_id;
        private readonly int goal_calories;
        private readonly int current_calories;
        private readonly int user_id;
        private readonly DateTime? completed_at;
        private readonly DateTime created_at;
        private readonly bool is_complete;

        // Public properties with only getters for encapsulation
        public int GoalId => goal_id;
        public int GoalCalories => goal_calories;
        public int CurrentCalories => current_calories;
        public int UserId => user_id;
        public DateTime? CompletedAt => completed_at;
        public DateTime CreatedAt => created_at;
        public bool IsComplete => is_complete;

        // Constructor to initialize the goal
        public Goal(int id, int goalCalories, int currentCalories, int userId, DateTime createdAt, bool isComplete, DateTime? completedAt = null)
        {
            this.goal_id = id;
            this.goal_calories = goalCalories;
            this.current_calories = currentCalories;
            this.user_id = userId;
            this.completed_at = completedAt;
            this.created_at = createdAt;
            this.is_complete = isComplete;
        }
    }
}
