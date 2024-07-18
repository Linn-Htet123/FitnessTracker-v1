using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    /// <summary>
    /// Validation class for validating user goals.
    /// </summary>
    internal class GoalValidation
    {
        /// <summary>
        /// Validates a user goal input.
        /// </summary>
        /// <param name="goal">The goal input to validate.</param>
        /// <returns>A ValidationResult object indicating success or containing error messages.</returns>
        public static ValidationResult ValidateGoal(string goal)
        {
            var errors = new Dictionary<string, string>();

            var goalValidation = ValidateGoalField(goal);
            if (!goalValidation.IsValid)
            {
                errors["goal"] = goalValidation.Message;
            }

            return new ValidationResult(errors);
        }

        private static ValidationResult ValidateGoalField(string goal)
        {
            var result = Validator.IsNotEmpty(goal, ValidationMessages.GoalRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(goal, ValidationMessages.GoalMustBeNumber);
            if (!result.IsValid) return result;

            var value = double.Parse(goal);
            result = Validator.IsWithinMinValue(value, 1, ValidationMessages.GoalMustBeGreaterThanZero);
            if (!result.IsValid) return result;

            return Validator.IsWithinMaxValue(value, 10000, ValidationMessages.GoalMustBeLessThanOrEqualTo10000);
        }
    }
}
