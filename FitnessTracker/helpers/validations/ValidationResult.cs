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
            Errors = new Dictionary<string, string>();
        }

        public ValidationResult(Dictionary<string, string> errors)
        {
            IsValid = errors.Count == 0;
            Errors = errors;
        }

        public static ValidationResult Success => new ValidationResult(true);
    }
}
