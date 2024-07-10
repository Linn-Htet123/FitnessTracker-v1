namespace FitnessTracker.utils
{
    internal static class CalculateActivity
    {
        public static int CalculateRunningCalories(double distance, double timeInMinutes, double speed, double weight)
        {
            double MET = CalculateRunningMET(speed);
            double caloriesBurned = (MET * weight * (timeInMinutes / 60));
            return (int)caloriesBurned;
        }

        private static double CalculateRunningMET(double speed)
        {
            // Calculate MET based on speed
            return (speed * 0.2) + 3.5;
        }
    }
}
