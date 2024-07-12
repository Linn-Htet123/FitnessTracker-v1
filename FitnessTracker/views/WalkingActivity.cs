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
    public partial class WalkingActivity : Form
    {
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();

        private Dictionary<string, Label> errorLabels;
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");
        readonly private Form parentForm;
        public WalkingActivity(Form parentForm)
        {
            InitializeComponent();
            InitializeErrorLabels();
            this.parentForm = parentForm;
        }

        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
             {
                 { "distance", Lbl_error_distance },
                 { "timeTaken", Lbl_error_time },
                 { "steps", Lbl_error_steps },
             };
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            string distance = Txt_distance.Text;
            string time = Txt_time_taken.Text;
            string steps = Txt_steps.Text;

            ClearLabels(errorLabels);

            var validationResult = WalkingValidation.ValidateWalking(steps, distance, time);

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }
            var burnedCalories = CalculateWalkingCalories(Convert.ToInt32(steps), Convert.ToDouble(distance), Convert.ToDouble(time), currentUser.Weight);

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Walking).Id;
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);

                LinkForm.Link(parentForm, new Dashboard());
            }
        }
    }
}
