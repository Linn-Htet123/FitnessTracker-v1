using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    internal class RunningValidation
    {
        public static ValidationResult ValidateRunning(string distance, string timeTaken, string speed)
        {
            var errors = new Dictionary<string, string>();

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

            var speedValidation = ValidateSpeed(speed);
            if (!speedValidation.IsValid)
            {
                errors["speed"] = speedValidation.Message;
            }

            return new ValidationResult(errors);
        }

        private static ValidationResult ValidateDistance(string distance)
        {
            var result = Validator.IsNotEmpty(distance, ValidationMessages.DistanceRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(distance, ValidationMessages.DistanceMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(distance, out double distanceValue))
            {
                result = Validator.IsWithinMinValue(distanceValue, 1, ValidationMessages.DistanceMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(distanceValue, 1000, ValidationMessages.DistanceMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.DistanceMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateTimeTaken(string timeTaken)
        {
            var result = Validator.IsNotEmpty(timeTaken, ValidationMessages.TimeTakenRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(timeTaken, ValidationMessages.TimeTakenMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(timeTaken, out double timeTakenValue))
            {
                result = Validator.IsWithinMinValue(timeTakenValue, 1, ValidationMessages.TimeTakenMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(timeTakenValue, 3000, ValidationMessages.TimeTakenMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.TimeTakenMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateSpeed(string speed)
        {
            var result = Validator.IsNotEmpty(speed, ValidationMessages.SpeedRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(speed, ValidationMessages.SpeedMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(speed, out double speedValue))
            {
                result = Validator.IsWithinMinValue(speedValue, 1, ValidationMessages.SpeedMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(speedValue, 50, ValidationMessages.SpeedMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.SpeedMustBeNumber);
            }

            return ValidationResult.Success;
        }
    }
}
