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
    public partial class SwimmingActivity : Form
    {
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();

        private Dictionary<string, Label> errorLabels;
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");
        readonly private Form parentForm;

        public SwimmingActivity(Form parentForm)
        {
            InitializeComponent();
            InitializeErrorLabels();
            this.parentForm = parentForm;
        }

        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "laps", Lbl_error_laps },
                { "timeTaken", Lbl_error_time },
                { "averageHeartRate", Lbl_error_heart_rate },

            };
        }

        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string laps = Txt_laps.Text;
            string time = Txt_time_taken.Text;
            string heartRate = Txt_heart_rate.Text;

            ClearLabels(errorLabels);

            var validationResult = SwimmingValidation.ValidateSwimming(laps, time, heartRate);

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }
            var burnedCalories = CalculateSwimmingCalories(Convert.ToInt32(laps), Convert.ToDouble(time), Convert.ToDouble(heartRate), currentUser.Weight);

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Swimming).Id;
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);

                LinkForm.Link(parentForm, new Dashboard());
            }
        }
    }

}
