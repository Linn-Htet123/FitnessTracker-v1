using System.Text.RegularExpressions;

namespace FitnessTracker.helpers.validations
{
    public static class Validator
    {
        public static ValidationResult IsNotEmpty(string input, string message = "This field is required.")
        {
            return string.IsNullOrWhiteSpace(input)
                ? new ValidationResult(false, message)
                : ValidationResult.Success;
        }

        public static ValidationResult HasMinLength(string input, int minLength, string message = "")
        {
            return input.Length < minLength
                ? new ValidationResult(false, message)
                : ValidationResult.Success;
        }

        public static ValidationResult HasMaxLength(string input, int maxLength, string message = "")
        {
            return input.Length > maxLength
                ? new ValidationResult(false, message)
                : ValidationResult.Success;
        }

        public static ValidationResult MatchesRegex(string input, string pattern, string message)
        {
            return !Regex.IsMatch(input, pattern)
                ? new ValidationResult(false, message)
                : ValidationResult.Success;
        }

        public static ValidationResult IsWithinMinValue(double input, double minValue, string message = "")
        {
            return input < minValue
                ? new ValidationResult(false, message)
                : ValidationResult.Success;
        }

        public static ValidationResult IsWithinMaxValue(double input, double maxValue, string message = "")
        {
            return input > maxValue
                ? new ValidationResult(false, message)
                : ValidationResult.Success;
        }

        public static ValidationResult IsNumeric(string input, string message = "This field must contain only numbers.")
        {
            return double.TryParse(input, out _)
                ? ValidationResult.Success
                : new ValidationResult(false, message);
        }
    }
}
