using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    internal class YogaValidation
    {
        public static ValidationResult ValidateYoga(string duration, string averageHeartRate, string intensityFactor)
        {
            var errors = new Dictionary<string, string>();

            var durationValidation = ValidateDuration(duration);
            if (!durationValidation.IsValid)
            {
                errors["duration"] = durationValidation.Message;
            }

            var heartRateValidation = ValidateAverageHeartRate(averageHeartRate);
            if (!heartRateValidation.IsValid)
            {
                errors["averageHeartRate"] = heartRateValidation.Message;
            }

            var intensityValidation = ValidateIntensityFactor(intensityFactor);
            if (!intensityValidation.IsValid)
            {
                errors["intensityFactor"] = intensityValidation.Message;
            }

            return new ValidationResult(errors);
        }

        private static ValidationResult ValidateDuration(string duration)
        {
            var result = Validator.IsNotEmpty(duration, ValidationMessages.DurationRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(duration, ValidationMessages.DurationMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(duration, out double durationValue))
            {
                result = Validator.IsWithinMinValue(durationValue, 1, ValidationMessages.DurationMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(durationValue, 240, ValidationMessages.DurationMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.DurationMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateAverageHeartRate(string averageHeartRate)
        {
            var result = Validator.IsNotEmpty(averageHeartRate, ValidationMessages.AverageHeartRateRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(averageHeartRate, ValidationMessages.AverageHeartRateMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(averageHeartRate, out double heartRateValue))
            {
                result = Validator.IsWithinMinValue(heartRateValue, 50, ValidationMessages.AverageHeartRateMinValue);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(heartRateValue, 200, ValidationMessages.AverageHeartRateMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.AverageHeartRateMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateIntensityFactor(string intensityFactor)
        {
            var result = Validator.IsNotEmpty(intensityFactor, ValidationMessages.IntensityFactorRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(intensityFactor, ValidationMessages.IntensityFactorMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(intensityFactor, out double intensityValue))
            {
                result = Validator.IsWithinMinValue(intensityValue, 1, ValidationMessages.IntensityFactorMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(intensityValue, 5, ValidationMessages.IntensityFactorMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.IntensityFactorMustBeNumber);
            }

            return ValidationResult.Success;
        }
    }
}
