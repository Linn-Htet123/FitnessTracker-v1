using FitnessTracker.helpers.validations;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    /// <summary>
    /// Utility class for rendering validation errors to labels in a Windows Forms application.
    /// </summary>
    public static class RenderValidationErrors
    {
        /// <summary>
        /// Renders validation errors to corresponding labels based on the ValidationResult.
        /// </summary>
        /// <param name="errorLabels">Dictionary mapping error keys to Label controls.</param>
        /// <param name="validationResult">ValidationResult containing validation errors.</param>
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
