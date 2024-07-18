using System.Text.RegularExpressions;

namespace FitnessTracker.helpers.validations
{
    public static class Validator
    {
        public static ValidationResult IsNotEmpty(string input, string message = "This field is required.")
        {
            return string.IsNullOrWhiteSpace(input)
                ? new ValidationResult(false, message) // Returns a validation result with an error message if the input is empty
                : ValidationResult.Success; // Returns a success result if the input is not empty
        }

        public static ValidationResult HasMinLength(string input, int minLength, string message = "")
        {
            return input.Length < minLength
                ? new ValidationResult(false, message) // Returns a validation result with an error message if the input is shorter than the minimum length
                : ValidationResult.Success; // Returns a success result if the input meets the minimum length requirement
        }

        public static ValidationResult HasMaxLength(string input, int maxLength, string message = "")
        {
            return input.Length > maxLength
                ? new ValidationResult(false, message) // Returns a validation result with an error message if the input exceeds the maximum length
                : ValidationResult.Success; // Returns a success result if the input meets the maximum length requirement
        }

        public static ValidationResult MatchesRegex(string input, string pattern, string message)
        {
            return !Regex.IsMatch(input, pattern)
                ? new ValidationResult(false, message) // Returns a validation result with an error message if the input does not match the regex pattern
                : ValidationResult.Success; // Returns a success result if the input matches the regex pattern
        }

        public static ValidationResult IsWithinMinValue(double input, double minValue, string message = "")
        {
            return input < minValue
                ? new ValidationResult(false, message) // Returns a validation result with an error message if the input is less than the minimum value
                : ValidationResult.Success; // Returns a success result if the input meets the minimum value requirement
        }

        public static ValidationResult IsWithinMaxValue(double input, double maxValue, string message = "")
        {
            return input > maxValue
                ? new ValidationResult(false, message) // Returns a validation result with an error message if the input exceeds the maximum value
                : ValidationResult.Success; // Returns a success result if the input meets the maximum value requirement
        }

        public static ValidationResult IsNumeric(string input, string message = "This field must contain only numbers.")
        {
            return double.TryParse(input, out _)
                ? ValidationResult.Success // Returns a success result if the input is numeric
                : new ValidationResult(false, message); // Returns a validation result with an error message if the input is not numeric
        }
    }
}
