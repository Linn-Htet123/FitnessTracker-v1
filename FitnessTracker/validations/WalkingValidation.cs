using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    internal class WalkingValidation
    {
        public static ValidationResult ValidateWalking(string steps, string distance, string timeTaken)
        {
            var errors = new Dictionary<string, string>();

            var stepsValidation = ValidateSteps(steps);
            if (!stepsValidation.IsValid)
            {
                errors["steps"] = stepsValidation.Message;
            }

            var distanceValidation = ValidateDistance(distance);
            if (!distanceValidation.IsValid)
            {
                errors["distance"] = distanceValidation.Message;
            }

            var timeTakenValidation = ValidateTimeTaken(timeTaken);
            if (!timeTakenValidation.IsValid)
            {
                errors["timeTaken"] = timeTakenValidation.Message;
            }

            return new ValidationResult(errors);
        }

        private static ValidationResult ValidateSteps(string steps)
        {
            var result = Validator.IsNotEmpty(steps, ValidationMessages.WalkingStepsRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(steps, ValidationMessages.WalkingStepsMustBeNumber);
            if (!result.IsValid) return result;

            if (int.TryParse(steps, out int stepsValue))
            {
                result = Validator.IsWithinMinValue(stepsValue, 1, ValidationMessages.WalkingStepsMustBeGreaterThanZero);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.WalkingStepsMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateDistance(string distance)
        {
            var result = Validator.IsNotEmpty(distance, ValidationMessages.WalkingDistanceRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(distance, ValidationMessages.WalkingDistanceMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(distance, out double distanceValue))
            {
                result = Validator.IsWithinMinValue(distanceValue, 1, ValidationMessages.WalkingDistanceMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(distanceValue, 100, ValidationMessages.WalkingDistanceMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.WalkingDistanceMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateTimeTaken(string timeTaken)
        {
            var result = Validator.IsNotEmpty(timeTaken, ValidationMessages.WalkingTimeTakenRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(timeTaken, ValidationMessages.WalkingTimeTakenMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(timeTaken, out double timeValue))
            {
                result = Validator.IsWithinMinValue(timeValue, 1, ValidationMessages.WalkingTimeTakenMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(timeValue, 1440, ValidationMessages.WalkingTimeTakenMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.WalkingTimeTakenMustBeNumber);
            }

            return ValidationResult.Success;
        }
    }
}
