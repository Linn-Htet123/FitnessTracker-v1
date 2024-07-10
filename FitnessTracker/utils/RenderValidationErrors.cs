using FitnessTracker.helpers.validations;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    public static class RenderValidationErrors
    {
        public static void RenderErrors(Dictionary<string, Label> errorLabels, ValidationResult validationResult)
        {
            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    if (errorLabels.ContainsKey(error.Key))
                    {
                        errorLabels[error.Key].Text = error.Value;
                    }
                }
            }
        }
    }
}
