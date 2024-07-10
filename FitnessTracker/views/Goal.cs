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
        GoalController goalController = new GoalController();
        private Dictionary<string, Label> errorLabels;
        private List<TextBox> textBoxes;
        public Goal()
        {
            InitializeComponent();
            InitializeErrorLabels();
            InitializeTextBoxes();
        }

        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "goal", Lbl_error_goal },
            };
        }

        private void InitializeTextBoxes()
        {
            textBoxes = new List<TextBox>
            {
              Txt_goal,
            };
        }

        private void Btn_goal_Click(object sender, System.EventArgs e)
        {
            string calories_goal = Txt_goal.Text.Trim();

            ClearLabels(errorLabels);

            var validationResult = GoalValidation.ValidateGoal(calories_goal);
            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }
            if (goalController.Create(Convert.ToInt32(calories_goal)))
            {
                InfoPopup("Goal set successfully");
                LinkForm.Link(this, new Dashboard());
            }
            else
            {
                ErrorPopup("Goal creation fails");
            }
            ClearTextBoxes(textBoxes);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new Dashboard());
        }


    }
}
