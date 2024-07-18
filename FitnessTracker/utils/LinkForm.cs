using System.Windows.Forms;

namespace FitnessTracker.utils
{
    /// <summary>
    /// Utility class for managing form navigation and visibility in a Windows Forms application.
    /// </summary>
    public static class LinkForm
    {
        private static Form activeForm = null;  // Tracks the currently active child form
        private static Form parentForm = null;  // Stores a reference to the parent form

        /// <summary>
        /// Switches from one form to another, hiding the current form and showing the new one.
        /// </summary>
        /// <param name="from">The form to hide.</param>
        /// <param name="to">The form to show.</param>
        public static void Link(Form from, Form to)
        {
            from.Hide();
            to.ShowDialog();
            from.Close();
        }

        /// <summary>
        /// Replaces the current active form within a specified panel.
        /// </summary>
        /// <param name="childForm">The new form to display.</param>
        /// <param name="panelMain">The panel where the form should be displayed.</param>
        public static void Replace(Form childForm, Panel panelMain)
        {
            // Close the current active form, if any
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Set the new form as the active form and configure its display properties
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Clear existing controls from the panel, add the new form, and bring it to the front
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /// <summary>
        /// Sets the parent form that may need to be hidden or shown.
        /// </summary>
        /// <param name="parent">The parent form to set.</param>
        public static void SetParentForm(Form parent)
        {
            parentForm = parent;
        }

        /// <summary>
        /// Hides the parent form, if one has been set.
        /// </summary>
        public static void HideParentForm()
        {
            parentForm?.Hide();
        }
    }
}
