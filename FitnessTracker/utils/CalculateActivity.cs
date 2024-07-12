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

        public static int CalculateBikingCalories(double distanceKm, double timeInMinutes, double speedKmh, double weight)
        {
            double MET = CalculateBikingMET(speedKmh);
            double caloriesBurned = (MET * weight * (timeInMinutes / 60)) + (0.9 * MET * weight * (distanceKm / 1.60934));
            return (int)caloriesBurned;
        }

        public static int CalculateSwimmingCalories(int laps, double timeInMinutes, double averageHeartRate, double weight)
        {
            double MET = CalculateSwimmingMET(averageHeartRate);
            double caloriesBurned = (MET * weight * (timeInMinutes / 60)) + (0.9 * MET * weight * (laps / 66.0)); // 66 is an average length of a pool lap in meters.
            return (int)caloriesBurned;
        }

        public static int CalculateJumpingRopeCalories(int jumps, double durationInMinutes, double intensityFactor, double weight)
        {
            double MET = 12.3; // Typical MET value for vigorous rope jumping
            double caloriesBurned = ((MET * intensityFactor * weight) / 200) * jumps * (durationInMinutes / 70);
            return (int)caloriesBurned;
        }

        public static int CalculateWalkingCalories(int steps, double distanceKm, double timeTakenMinutes, double weightKg)
        {
            double MET = 3.8; // Typical MET value for walking at a moderate pace
            double caloriesBurned = ((MET * weightKg) / 200) * timeTakenMinutes;
            return (int)caloriesBurned;
        }

        private static double CalculateRunningMET(double speed)
        {
            return (speed * 0.2) + 3.5;
        }

        private static double CalculateBikingMET(double speed)
        {
            if (speed < 16)
                return 4.0; // Light effort
            else if (speed < 20)
                return 8.0; // Moderate effort
            else if (speed < 24)
                return 10.0; // Vigorous effort
            else
                return 12.0; // Very vigorous effort
        }

        private static double CalculateSwimmingMET(double averageHeartRate)
        {
            if (averageHeartRate < 100)
                return 6.0; // Light effort
            else if (averageHeartRate < 130)
                return 8.0; // Moderate effort
            else
                return 10.0; // Vigorous effort
        }
    }
}
