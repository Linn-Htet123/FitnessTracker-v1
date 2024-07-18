using FitnessTracker.enums;
using System;

namespace FitnessTracker.utils
{
    /// <summary>
    /// Utility class for date-related operations.
    /// </summary>
    static class Date
    {
        /// <summary>
        /// Generates a greeting based on the time of day and day of the week.
        /// </summary>
        /// <param name="date">The date/time to generate the greeting for.</param>
        /// <returns>A string greeting based on the time of day and day of the week.</returns>
        public static string GetGreet(DateTime date)
        {
            int hour = date.Hour;
            DayOfWeek day = date.DayOfWeek;

            int splitMorningEnd = 12; // 12 PM is the end of morning
            int splitAfternoonEnd = 15; // 3 PM is the end of afternoon
            int splitEveningEnd = 19; // 7 PM is the end of evening

            bool isMorning = 3 <= hour && hour < splitMorningEnd;
            bool isAfternoon = splitMorningEnd <= hour && hour < splitAfternoonEnd;
            bool isEvening = splitAfternoonEnd <= hour && hour < splitEveningEnd;
            bool isNight = hour >= splitEveningEnd || hour < 3;

            bool isFridayAfternoon = day == DayOfWeek.Friday && (isAfternoon || isEvening);
            bool isSaturdayMorning = day == DayOfWeek.Saturday && isMorning;

            if (isFridayAfternoon || isSaturdayMorning)
            {
                return "Have a good weekend";
            }
            else if (isMorning)
            {
                return "Good morning";
            }
            else if (isAfternoon)
            {
                return "Good afternoon";
            }
            else if (isNight)
            {
                return "Good night";
            }
            return "Good evening";
        }

        /// <summary>
        /// Determines the completion status of a goal based on its creation and completion times.
        /// </summary>
        /// <param name="created_at">The date/time when the goal was created.</param>
        /// <param name="completed_at">The optional date/time when the goal was completed.</param>
        /// <returns>The completion status of the goal.</returns>
        public static GoalCompletionStatus GetCompletionStatus(DateTime created_at, DateTime? completed_at)
        {
            if (completed_at == null)
            {
                return GoalCompletionStatus.MoreThanOneWeek;
            }

            DateTime completionTime = completed_at.Value;
            TimeSpan timeSinceCreation = completionTime - created_at;

            if (timeSinceCreation.TotalDays <= 1)
            {
                return GoalCompletionStatus.WithinOneDay;
            }
            else if (timeSinceCreation.TotalDays <= 7)
            {
                return GoalCompletionStatus.WithinOneWeek;
            }
            else
            {
                return GoalCompletionStatus.MoreThanOneWeek;
            }
        }
    }
}
