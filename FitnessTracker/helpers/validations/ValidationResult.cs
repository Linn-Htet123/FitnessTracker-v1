using System.Collections.Generic;

namespace FitnessTracker.helpers.validations
{
    public class ValidationResult
    {
        public bool IsValid { get; }
        public string Message { get; }
        public Dictionary<string, string> Errors { get; }

        public ValidationResult(bool isValid, string message = "")
        {
            IsValid = isValid;
            Message = message;
            Errors = new Dictionary<string, string>(); // Initializes an empty dictionary for errors
        }

        public ValidationResult(Dictionary<string, string> errors)
        {
            IsValid = errors.Count == 0; // Sets IsValid to true if there are no errors
            Errors = errors; // Assigns the errors dictionary
        }

        public static ValidationResult Success => new ValidationResult(true); // Provides a static property for a successful validation result
    }
}
