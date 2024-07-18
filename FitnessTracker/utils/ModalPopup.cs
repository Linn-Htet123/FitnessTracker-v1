using System.Windows.Forms;

namespace FitnessTracker.utils
{
    /// <summary>
    /// Utility class for displaying modal popups (information, warning, error, confirmation) in a Windows Forms application.
    /// </summary>
    internal class ModalPopup
    {
        /// <summary>
        /// Displays an information popup with the specified message.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public static void InfoPopup(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Displays a warning popup with the specified message.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public static void WarningPopup(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Displays an error popup with the specified message.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public static void ErrorPopup(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Displays a confirmation popup with the specified message and returns the user's response.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <returns>The dialog result indicating the user's choice (Yes or No).</returns>
        public static DialogResult ConfirmationPopup(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
