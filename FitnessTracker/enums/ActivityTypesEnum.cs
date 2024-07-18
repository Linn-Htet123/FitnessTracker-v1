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
                    return "Walking"; // Returns the string "Walking" for the Walking enum value
                case ActivityTypesEnum.Swimming:
                    return "Swimming"; // Returns the string "Swimming" for the Swimming enum value
                case ActivityTypesEnum.Yoga:
                    return "Yoga"; // Returns the string "Yoga" for the Yoga enum value
                case ActivityTypesEnum.JumpingRope:
                    return "Jumping Rope"; // Returns the string "Jumping Rope" for the JumpingRope enum value
                case ActivityTypesEnum.Running:
                    return "Running"; // Returns the string "Running" for the Running enum value
                case ActivityTypesEnum.Biking:
                    return "Biking"; // Returns the string "Biking" for the Biking enum value
                default:
                    throw new ArgumentOutOfRangeException(nameof(activity), activity, null); // Throws an exception for any unknown enum value
            }
        }
    }
}
