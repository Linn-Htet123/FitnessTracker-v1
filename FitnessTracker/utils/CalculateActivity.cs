namespace FitnessTracker.utils
{
    internal static class CalculateActivity
    {
        public static int CalculateRunningCalories(double distance, double timeInMinutes, double speed, double weight)
        {
            double MET = CalculateRunningMET(speed);
            double caloriesBurned = (MET * weight * (timeInMinutes / 60)) + (0.9 * MET * weight * (distance / 1609.34));
            return (int)caloriesBurned;
        }

        public static int CalculateYogaCalories(double durationInMinutes, double averageHeartRate, double weight, double intensityFactor)
        {
            double MET = 2.5;
            double caloriesBurned = ((MET * intensityFactor * weight) / 200) * durationInMinutes * (averageHeartRate / 70);
            return (int)caloriesBurned;
        }

        private static double CalculateRunningMET(double speed)
        {
            return (speed * 0.2) + 3.5;
        }
    }
}
