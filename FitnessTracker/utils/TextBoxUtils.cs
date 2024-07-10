using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    internal static class TextBoxUtils
    {
        public static void ClearTextBoxes(IEnumerable<TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }
    }
}
