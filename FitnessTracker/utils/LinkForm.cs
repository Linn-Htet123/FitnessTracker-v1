using System.Windows.Forms;

namespace FitnessTracker.utils
{
    public static class LinkForm
    {
        private static Form activeForm = null;
        private static Form parentForm = null;

        public static void Link(Form from, Form to)
        {
            from.Hide();
            to.ShowDialog();
            from.Close();
        }

        public static void Replace(Form childForm, Panel panelMain)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void SetParentForm(Form parent)
        {
            parentForm = parent;
        }

        public static void HideParentForm()
        {
            parentForm?.Hide();
        }
    }
}
