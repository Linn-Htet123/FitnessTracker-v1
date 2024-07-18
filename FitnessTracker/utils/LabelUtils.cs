using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    /// <summary>
    /// Utility class for handling operations on labels in a Windows Forms application.
    /// </summary>
    internal static class LabelUtils
    {
        /// <summary>
        /// Clears the text of all labels in the provided dictionary.
        /// </summary>
        /// <param name="labels">Dictionary where keys are label identifiers and values are Label controls.</param>
        public static void ClearLabels(Dictionary<string, Label> labels)
        {
            foreach (var label in labels.Values)
            {
                label.Text = "";
            }
        }
    }
}
