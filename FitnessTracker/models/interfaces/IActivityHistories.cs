using System;

namespace FitnessTracker.models.interfaces
{
    public interface IActivityHistories
    {
        int Id { get; }
        int ActivityTypeId { get; }
        int UserId { get; }
        double BurnedCalories { get; }
        DateTime CreatedAt { get; }
    }
}
