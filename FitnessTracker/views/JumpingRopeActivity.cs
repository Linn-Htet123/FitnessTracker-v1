using FitnessTracker.controllers;
using FitnessTracker.enums;
using FitnessTracker.models;
using FitnessTracker.services;
using FitnessTracker.utils;
using FitnessTracker.validations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FitnessTracker.utils.CalculateActivity;
using static FitnessTracker.utils.LabelUtils;

namespace FitnessTracker.views
{
    public partial class JumpingRopeActivity : Form
    {
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();

        private Dictionary<string, Label> errorLabels;
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");
        readonly private Form parentForm;
        public JumpingRopeActivity(Form parentForm)
        {
            InitializeComponent();
            InitializeErrorLabels();
            this.parentForm = parentForm;
        }
        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "jumps", Lbl_error_jumps },
                { "duration", Lbl_error_time },
                { "intensityFactor", Lbl_error_intensity_factor },

            };
        }

        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string jumps = Txt_jumps.Text;
            string time = Txt_time_taken.Text;
            string intensityFactor = Txt_intensity_factor.Text;

            ClearLabels(errorLabels);

            var validationResult = JumpingRopeValidation.ValidateJumpingRope(jumps, time, intensityFactor);

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }
            var burnedCalories = CalculateJumpingRopeCalories(Convert.ToInt32(jumps), Convert.ToDouble(time), Convert.ToDouble(intensityFactor), currentUser.Weight);

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.JumpingRope).Id;
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);

                LinkForm.Link(parentForm, new Dashboard());
            }
        }
    }
}
