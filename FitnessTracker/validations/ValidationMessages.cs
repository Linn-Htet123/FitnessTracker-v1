namespace FitnessTracker.validations
{
    public static class ValidationMessages
    {
        // Goal validation
        public const string GoalRequired = "Goal is required.";
        public const string GoalMustBeNumber = "Goal must be a number.";
        public const string GoalMustBeGreaterThanZero = "Goal must be greater than zero.";
        public const string GoalMustBeLessThanOrEqualTo10000 = "Goal must be less than or equal to 10000.";

        // Login and Signup Validation
        public const string UsernameRequired = "Username is required.";
        public const string UsernameMaxLength = "Username must be at least 20 characters long.";
        public const string UsernameInvalidCharacters = "Username must contain only letters and numbers.";

        public const string PasswordRequired = "Password is required.";
        public const string PasswordMinLength = "Password must be at least 12 characters long.";
        public const string PasswordMaxLength = "Password must be at most 12 characters long.";
        public const string PasswordMustContainLowercase = "Password must contain at least one lowercase letter.";
        public const string PasswordMustContainUppercase = "Password must contain at least one uppercase letter.";
        public const string PasswordMustContainNumber = "Password must contain at least one number.";
        public const string PasswordMustContainSpecialCharacter = "Password must contain at least one special character.";

        public const string ConfirmPasswordMismatch = "Password and confirm password must be the same.";

        public const string WeightRequired = "Weight is required.";
        public const string WeightMustBeNumber = "Weight must be a number.";
        public const string WeightMinValue = "Weight must be at least 44 kg.";
        public const string WeightMaxValue = "Weight must not exceed 645 kg.";

        public const string HeightRequired = "Height is required.";
        public const string HeightMustBeNumber = "Height must be a number.";
        public const string HeightMinValue = "Height must be at least 54 cm.";
        public const string HeightMaxValue = "Height must not exceed 272 cm.";

        // Running Activity validation
        public const string DistanceRequired = "Distance is required.";
        public const string DistanceMustBeNumber = "Distance must be a number.";
        public const string DistanceMustBeGreaterThanZero = "Distance must be greater than zero.";
        public const string DistanceMaxValue = "Distance must not exceed 100 km.";

        public const string TimeTakenRequired = "Time taken is required.";
        public const string TimeTakenMustBeNumber = "Time taken must be a number.";
        public const string TimeTakenMustBeGreaterThanZero = "Time taken must be greater than zero.";
        public const string TimeTakenMaxValue = "Time taken must not exceed 1000 minutes.";

        public const string SpeedRequired = "Speed is required.";
        public const string SpeedMustBeNumber = "Speed must be a number.";
        public const string SpeedMustBeGreaterThanZero = "Speed must be greater than zero.";
        public const string SpeedMaxValue = "Speed must not exceed 50 km/h.";

        // Yoga Activity validation
        public const string DurationRequired = "Duration is required.";
        public const string DurationMustBeNumber = "Duration must be a number.";
        public const string DurationMustBeGreaterThanZero = "Duration must be greater than zero.";
        public const string DurationMaxValue = "Duration must not exceed 240 minutes.";

        public const string AverageHeartRateRequired = "Average heart rate is required.";
        public const string AverageHeartRateMustBeNumber = "Average heart rate must be a number.";
        public const string AverageHeartRateMinValue = "Average heart rate must be at least 50 bpm.";
        public const string AverageHeartRateMaxValue = "Average heart rate must not exceed 200 bpm.";

        public const string IntensityFactorRequired = "Intensity factor is required.";
        public const string IntensityFactorMustBeNumber = "Intensity factor must be a number.";
        public const string IntensityFactorMustBeGreaterThanZero = "Intensity factor must be greater than zero.";
        public const string IntensityFactorMaxValue = "Intensity factor must not exceed 5.";
    }
}
