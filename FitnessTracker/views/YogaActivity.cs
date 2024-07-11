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
    public partial class YogaActivity : Form
    {
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();

        private Dictionary<string, Label> errorLabels;
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");
        readonly private Form parentForm;
        public YogaActivity(Form parentForm)
        {
            InitializeComponent();
            InitializeErrorLabels();
            this.parentForm = parentForm;
        }

        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "duration", Lbl_error_time },
                { "averageHeartRate", Lbl_error_heart_rate },
                { "intensityFactor", Lbl_error_intensity_factor },

            };
        }

        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string heartRate = Txt_heart_rate.Text;
            string duration = Txt_time_taken.Text;
            string intensityFactor = Txt_intensity_factor.Text;

            ClearLabels(errorLabels);

            var validationResult = YogaValidation.ValidateYoga(duration, heartRate, intensityFactor);

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }
            var burnedCalories = CalculateYogaCalories(Convert.ToDouble(duration), Convert.ToDouble(heartRate), Convert.ToDouble(intensityFactor), currentUser.Weight);

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Yoga).Id;
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);

                LinkForm.Link(parentForm, new Dashboard());
            }
        }

    }
}
