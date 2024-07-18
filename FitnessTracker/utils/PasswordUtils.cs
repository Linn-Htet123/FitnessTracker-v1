using System.Windows.Forms;

namespace FitnessTracker.utils
{
    /// <summary>
    /// Utility class for managing password visibility in a Windows Forms application.
    /// </summary>
    internal static class PasswordUtils
    {
        /// <summary>
        /// Toggles the visibility of the password based on the state of the checkbox.
        /// </summary>
        /// <param name="toggleButton">The checkbox used to toggle password visibility.</param>
        /// <param name="password">The textbox containing the password.</param>
        public static void PasswordShowHide(CheckBox toggleButton, TextBox password)
        {
            password.UseSystemPasswordChar = !toggleButton.Checked;
        }
    }
}
