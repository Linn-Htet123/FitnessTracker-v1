using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    /// <summary>
    /// Validation class for validating jumping rope activity inputs.
    /// </summary>
    internal class JumpingRopeValidation
    {
        /// <summary>
        /// Validates the jumping rope activity inputs.
        /// </summary>
        /// <param name="jumps">The number of jumps input to validate.</param>
        /// <param name="duration">The duration of activity input to validate.</param>
        /// <param name="intensityFactor">The intensity factor input to validate.</param>
        /// <returns>A ValidationResult object indicating success or containing error messages.</returns>
        public static ValidationResult ValidateJumpingRope(string jumps, string duration, string intensityFactor)
        {
            var errors = new Dictionary<string, string>();

            var jumpsValidation = ValidateJumps(jumps);
            if (!jumpsValidation.IsValid)
            {
                errors["jumps"] = jumpsValidation.Message;
            }

            var durationValidation = ValidateDuration(duration);
            if (!durationValidation.IsValid)
            {
                errors["duration"] = durationValidation.Message;
            }

            var intensityValidation = ValidateIntensityFactor(intensityFactor);
            if (!intensityValidation.IsValid)
            {
                errors["intensityFactor"] = intensityValidation.Message;
            }

            return new ValidationResult(errors);
        }

        private static ValidationResult ValidateJumps(string jumps)
        {
            var result = Validator.IsNotEmpty(jumps, ValidationMessages.JumpingRopeJumpsRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(jumps, ValidationMessages.JumpingRopeJumpsMustBeNumber);
            if (!result.IsValid) return result;

            if (int.TryParse(jumps, out int jumpsValue))
            {
                result = Validator.IsWithinMinValue(jumpsValue, 1, ValidationMessages.JumpingRopeJumpsMustBeGreaterThanZero);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.JumpingRopeJumpsMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateDuration(string duration)
        {
            var result = Validator.IsNotEmpty(duration, ValidationMessages.JumpingRopeDurationRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(duration, ValidationMessages.JumpingRopeDurationMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(duration, out double durationValue))
            {
                result = Validator.IsWithinMinValue(durationValue, 1, ValidationMessages.JumpingRopeDurationMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(durationValue, 240, ValidationMessages.JumpingRopeDurationMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.JumpingRopeDurationMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateIntensityFactor(string intensityFactor)
        {
            var result = Validator.IsNotEmpty(intensityFactor, ValidationMessages.JumpingRopeIntensityFactorRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(intensityFactor, ValidationMessages.JumpingRopeIntensityFactorMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(intensityFactor, out double intensityValue))
            {
                result = Validator.IsWithinMinValue(intensityValue, 1, ValidationMessages.JumpingRopeIntensityFactorMustBeGreaterThanZero);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(intensityValue, 2.0, ValidationMessages.JumpingRopeIntensityFactorMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.JumpingRopeIntensityFactorMustBeNumber);
            }

            return ValidationResult.Success;
        }
    }
}
