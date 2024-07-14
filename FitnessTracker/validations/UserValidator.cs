using FitnessTracker.helpers.validations;
using System.Collections.Generic;

namespace FitnessTracker.validations
{
    public static class UserValidator
    {
        public static ValidationResult ValidateLogin(string username, string password)
        {
            var errors = new Dictionary<string, string>();

            var usernameValidation = ValidateUsername(username);
            if (!usernameValidation.IsValid)
            {
                errors["username"] = usernameValidation.Message;
            }

            var passwordValidation = ValidatePassword(password);
            if (!passwordValidation.IsValid)
            {
                errors["password"] = passwordValidation.Message;
            }

            return new ValidationResult(errors);
        }

        public static ValidationResult ValidateSignup(string username, string password, string confirmPassword, string weight, string height)
        {
            var errors = new Dictionary<string, string>();

            var usernameValidation = ValidateUsername(username);
            if (!usernameValidation.IsValid)
            {
                errors["username"] = usernameValidation.Message;
            }

            var passwordValidation = ValidatePassword(password);
            if (!passwordValidation.IsValid)
            {
                errors["password"] = passwordValidation.Message;
            }
            var confirmPasswordValidation = ValidateConfirmPassword(password, confirmPassword);
            if (!confirmPasswordValidation.IsValid)
            {
                errors["confirmPassword"] = confirmPasswordValidation.Message;
            }

            var weightValidation = ValidateWeight(weight);
            if (!weightValidation.IsValid)
            {
                errors["weight"] = weightValidation.Message;
            }

            var heightValidation = ValidateHeight(height);
            if (!heightValidation.IsValid)
            {
                errors["height"] = heightValidation.Message;
            }

            return new ValidationResult(errors);
        }

        private static ValidationResult ValidateUsername(string username)
        {
            var result = Validator.IsNotEmpty(username, ValidationMessages.UsernameRequired);
            if (!result.IsValid) return result;

            result = Validator.HasMaxLength(username, 20, ValidationMessages.UsernameMaxLength);
            if (!result.IsValid) return result;

            return Validator.MatchesRegex(username, @"^[a-zA-Z0-9]+$", ValidationMessages.UsernameInvalidCharacters);
        }

        private static ValidationResult ValidatePassword(string password)
        {
            var result = Validator.IsNotEmpty(password, ValidationMessages.PasswordRequired);
            if (!result.IsValid) return result;

            result = Validator.HasMinLength(password, 12, ValidationMessages.PasswordMinLength);
            if (!result.IsValid) return result;

            result = Validator.HasMaxLength(password, 12, ValidationMessages.PasswordMaxLength);
            if (!result.IsValid) return result;

            result = Validator.MatchesRegex(password, @"[a-z]", ValidationMessages.PasswordMustContainLowercase);
            if (!result.IsValid) return result;

            result = Validator.MatchesRegex(password, @"[A-Z]", ValidationMessages.PasswordMustContainUppercase);
            if (!result.IsValid) return result;

            result = Validator.MatchesRegex(password, @"\d", ValidationMessages.PasswordMustContainNumber);
            if (!result.IsValid) return result;

            return Validator.MatchesRegex(password, @"[@$!%*?&]", ValidationMessages.PasswordMustContainSpecialCharacter);
        }

        private static ValidationResult ValidateConfirmPassword(string password, string confirmPassword)
        {
            return password != confirmPassword
                ? new ValidationResult(false, ValidationMessages.ConfirmPasswordMismatch)
                : ValidationResult.Success;
        }

        private static ValidationResult ValidateWeight(string weightInput)
        {
            var result = Validator.IsNotEmpty(weightInput, ValidationMessages.WeightRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(weightInput, ValidationMessages.WeightMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(weightInput, out double weight))
            {
                result = Validator.IsWithinMinValue(weight, 44, ValidationMessages.WeightMinValue);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(weight, 635, ValidationMessages.WeightMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.WeightMustBeNumber);
            }

            return ValidationResult.Success;
        }

        private static ValidationResult ValidateHeight(string heightInput)
        {
            var result = Validator.IsNotEmpty(heightInput, ValidationMessages.HeightRequired);
            if (!result.IsValid) return result;

            result = Validator.IsNumeric(heightInput, ValidationMessages.HeightMustBeNumber);
            if (!result.IsValid) return result;

            if (double.TryParse(heightInput, out double height))
            {
                result = Validator.IsWithinMinValue(height, 54, ValidationMessages.HeightMinValue);
                if (!result.IsValid) return result;

                result = Validator.IsWithinMaxValue(height, 272, ValidationMessages.HeightMaxValue);
                if (!result.IsValid) return result;
            }
            else
            {
                return new ValidationResult(false, ValidationMessages.HeightMustBeNumber);
            }

            return ValidationResult.Success;
        }
    }
}
