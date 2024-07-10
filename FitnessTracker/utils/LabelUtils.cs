using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    internal static class LabelUtils
    {
        public static void ClearLabels(Dictionary<string, Label> labels)
        {
            foreach (var label in labels.Values)
            {
                label.Text = "";
            }
        }
    }
}
