using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    internal class LabelGenerator
    {
        public static List<Label> GenerateLabels(List<Dictionary<string, object>> data, int initialTopPosition)
        {
            List<Label> labels = new List<Label>();

            int labelTop = initialTopPosition;
            foreach (var item in data)
            {
                foreach (var kvp in item)
                {
                    Label lbl = CreateLabel($"{kvp.Key}: {kvp.Value}", labelTop);
                    labels.Add(lbl);
                    labelTop += 30;
                }
                labelTop += 10;
            }

            return labels;
        }

        private static Label CreateLabel(string text, int top)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = text;
            label.Location = new System.Drawing.Point(20, top);
            return label;
        }
    }
}
