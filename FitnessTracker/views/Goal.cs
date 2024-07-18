using FitnessTracker.controllers;
using FitnessTracker.utils;
using FitnessTracker.validations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FitnessTracker.utils.LabelUtils;
using static FitnessTracker.utils.ModalPopup;
using static FitnessTracker.utils.TextBoxUtils;

namespace FitnessTracker.views
{
    public partial class Goal : Form
    {
        // Controllers for goal management
        private GoalController goalController = new GoalController();

        // Dictionary to store error labels for validation
        private Dictionary<string, Label> errorLabels;

        // List to store text boxes for easy clearing
        private List<TextBox> textBoxes;

        public Goal()
        {
            InitializeComponent();
            InitializeErrorLabels();    // Initialize error labels
            InitializeTextBoxes();      // Initialize text boxes
        }

        // Initialize error labels dictionary
        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "goal", Lbl_error_goal },    // Associate error label with UI control
            };
        }

        // Initialize text boxes list
        private void InitializeTextBoxes()
        {
            textBoxes = new List<TextBox>
            {
                Txt_goal,   // Add goal text box to list for easy clearing
            };
        }

        // Event handler for setting goal button click
        private void Btn_goal_Click(object sender, System.EventArgs e)
        {
            string calories_goal = Txt_goal.Text.Trim();   // Get goal calories input

            ClearLabels(errorLabels);   // Clear previous validation error labels

            var validationResult = GoalValidation.ValidateGoal(calories_goal);   // Validate goal input
            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);   // Render validation errors if any
                return;
            }

            if (goalController.Create(Convert.ToInt32(calories_goal)))   // Attempt to create goal
            {
                InfoPopup("Goal set successfully");   // Display success message
                LinkForm.Link(this, new Dashboard());   // Navigate back to dashboard
            }
            else
            {
                ErrorPopup("Goal creation fails");   // Display error message on goal creation failure
            }

            ClearTextBoxes(textBoxes);   // Clear text boxes after processing
        }

        // Event handler for back button click
        private void Btn_back_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new Dashboard());   // Navigate back to dashboard
        }
    }
}
