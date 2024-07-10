using System;

namespace FitnessTracker.enums
{
    public enum ActivityTypesEnum
    {
        Walking,
        Swimming,
        Yoga,
        JumpingRope,
        Running,
        Biking
    }

    public static class ActivityTypesExtensions
    {
        public static string ToActivityName(this ActivityTypesEnum activity)
        {
            switch (activity)
            {
                case ActivityTypesEnum.Walking:
                    return "Walking";
                case ActivityTypesEnum.Swimming:
                    return "Swimming";
                case ActivityTypesEnum.Yoga:
                    return "Yoga";
                case ActivityTypesEnum.JumpingRope:
                    return "Jumping Rope";
                case ActivityTypesEnum.Running:
                    return "Running";
                case ActivityTypesEnum.Biking:
                    return "Biking";
                default:
                    throw new ArgumentOutOfRangeException(nameof(activity), activity, null);
            }
        }
    }
}
