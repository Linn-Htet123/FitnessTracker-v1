using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessTracker.utils
{
    internal class LabelGenerator
    {
        public static List<Label> GenerateLabels(
            List<Dictionary<string, object>> data,
            int initialTopPosition,
            List<LabelSpec> labelSpecs)
        {
            List<Label> labels = new List<Label>();

            int labelTop = initialTopPosition;
            foreach (var item in data)
            {
                foreach (var spec in labelSpecs)
                {
                    string text = item.ContainsKey(spec.Key) ? item[spec.Key].ToString() : "N/A";
                    Label label = CreateLabel(text, labelTop, spec.LeftPosition, spec.FontSize, spec.FontStyle);
                    labels.Add(label);
                }

                labelTop += 30;
            }

            return labels;
        }

        private static Label CreateLabel(string text, int top, int left, int fontSize, FontStyle fontStyle)
        {
            Label label = new Label
            {
                AutoSize = true,
                Text = text,
                Location = new Point(left, top),
                Font = new Font("Arial", fontSize, fontStyle) // Customize font if needed
            };
            return label;
        }

        public class LabelSpec
        {
            public string Key { get; set; }
            public int LeftPosition { get; set; }
            public int FontSize { get; set; }
            public FontStyle FontStyle { get; set; }

            public LabelSpec(string key, int leftPosition, int fontSize, FontStyle fontStyle)
            {
                Key = key;
                LeftPosition = leftPosition;
                FontSize = fontSize;
                FontStyle = fontStyle;
            }
        }
    }
}
