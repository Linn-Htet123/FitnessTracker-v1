using System;

namespace FitnessTracker.models.interfaces
{
    public interface IGoal
    {
        int GoalId { get; }
        int GoalCalories { get; }
        int CurrentCalories { get; }
        int UserId { get; }
        DateTime? CompletedAt { get; }
        DateTime CreatedAt { get; }
        bool IsComplete { get; }
    }
}
