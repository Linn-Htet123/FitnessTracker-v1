using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    /// <summary>
    /// Validation class for validating input related to biking activities.
    /// </summary>
    internal class BikingValidation
    {
        /// <summary>
        /// Validates biking activity inputs for distance, time taken, and speed.
        /// </summary>
        /// <param name="distance">The distance input to validate.</param>
        /// <param name="timeTaken">The time taken input to validate.</param>
        /// <param name="speed">The speed input to validate.</param>
        /// <returns>A ValidationResult object indicating success or containing error messages.</returns>
        public static ValidationResult ValidateBiking(string distance, string timeTaken, string speed)
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
            var result = Validator.IsNotEmpty(distance, ValidationMessages.BikingDistanceRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(distance, ValidationMessages.BikingDistanceMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(distance, out double distanceValue))
            {
                result = Validator.IsWithinMinValue(distanceValue, 1, ValidationMessages.BikingDistanceMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(distanceValue, 200, ValidationMessages.BikingDistanceMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.BikingDistanceMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateTimeTaken(string timeTaken)
        {
            var result = Validator.IsNotEmpty(timeTaken, ValidationMessages.BikingTimeTakenRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(timeTaken, ValidationMessages.BikingTimeTakenMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(timeTaken, out double timeValue))
            {
                result = Validator.IsWithinMinValue(timeValue, 1, ValidationMessages.BikingTimeTakenMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(timeValue, 1440, ValidationMessages.BikingTimeTakenMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.BikingTimeTakenMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateSpeed(string speed)
        {
            var result = Validator.IsNotEmpty(speed, ValidationMessages.BikingSpeedRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(speed, ValidationMessages.BikingSpeedMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(speed, out double speedValue))
            {
                result = Validator.IsWithinMinValue(speedValue, 1, ValidationMessages.BikingSpeedMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(speedValue, 60, ValidationMessages.BikingSpeedMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.BikingSpeedMustBeNumber);
            }

            return ValidationResult.Success;
        }
    }
}
