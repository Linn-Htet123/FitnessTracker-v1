using System.Windows.Forms;

namespace FitnessTracker.utils
{
    internal static class PasswordUtils
    {
        public static void PasswordShowHide(CheckBox toggleButton, TextBox password)
        {
            password.UseSystemPasswordChar = !toggleButton.Checked;
        }

    }
}
