using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    /// <summary>
    /// Utility class for manipulating TextBox controls in a Windows Forms application.
    /// </summary>
    internal static class TextBoxUtils
    {
        /// <summary>
        /// Clears the text of each TextBox in the provided collection.
        /// </summary>
        /// <param name="textBoxes">Collection of TextBox controls to be cleared.</param>
        public static void ClearTextBoxes(IEnumerable<TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }
    }
}
