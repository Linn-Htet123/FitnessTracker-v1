using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    internal class SwimmingValidation
    {
        public static ValidationResult ValidateSwimming(string laps, string timeTaken, string averageHeartRate)
        {
            var errors = new Dictionary<string, string>();

            var lapsValidation = ValidateLaps(laps);
            if (!lapsValidation.IsValid)
            {
                errors["laps"] = lapsValidation.Message;
            }

            var timeTakenValidation = ValidateTimeTaken(timeTaken);
            if (!timeTakenValidation.IsValid)
            {
                errors["timeTaken"] = timeTakenValidation.Message;
            }

            var heartRateValidation = ValidateAverageHeartRate(averageHeartRate);
            if (!heartRateValidation.IsValid)
            {
                errors["averageHeartRate"] = heartRateValidation.Message;
            }

            return new ValidationResult(errors);
        }

        private static ValidationResult ValidateLaps(string laps)
        {
            var result = Validator.IsNotEmpty(laps, ValidationMessages.SwimmingLapsRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(laps, ValidationMessages.SwimmingLapsMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(laps, out double lapsValue))
            {
                result = Validator.IsWithinMinValue(lapsValue, 1, ValidationMessages.SwimmingLapsMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(lapsValue, 1000, ValidationMessages.SwimmingLapsMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.SwimmingLapsMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateTimeTaken(string timeTaken)
        {
            var result = Validator.IsNotEmpty(timeTaken, ValidationMessages.SwimmingTimeTakenRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(timeTaken, ValidationMessages.SwimmingTimeTakenMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(timeTaken, out double timeTakenValue))
            {
                result = Validator.IsWithinMinValue(timeTakenValue, 1, ValidationMessages.SwimmingTimeTakenMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(timeTakenValue, 1000, ValidationMessages.SwimmingTimeTakenMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.SwimmingTimeTakenMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateAverageHeartRate(string averageHeartRate)
        {
            var result = Validator.IsNotEmpty(averageHeartRate, ValidationMessages.SwimmingAverageHeartRateRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(averageHeartRate, ValidationMessages.SwimmingAverageHeartRateMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(averageHeartRate, out double heartRateValue))
            {
                result = Validator.IsWithinMinValue(heartRateValue, 50, ValidationMessages.SwimmingAverageHeartRateMinValue);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(heartRateValue, 200, ValidationMessages.SwimmingAverageHeartRateMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.SwimmingAverageHeartRateMustBeNumber);
            }

            return ValidationResult.Success;
        }
    }
}
