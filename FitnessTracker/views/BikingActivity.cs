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
    public partial class BikingActivity : Form
    {
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();

        private Dictionary<string, Label> errorLabels;
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");
        readonly private Form parentForm;

        public BikingActivity(Form parentForm)
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
                { "speed", Lbl_error_speed },

            };
        }

        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string distance = Txt_distance.Text;
            string time = Txt_time_taken.Text;
            string speed = Txt_speed.Text;

            ClearLabels(errorLabels);

            var validationResult = BikingValidation.ValidateBiking(distance, time, speed);

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }
            var burnedCalories = CalculateBikingCalories(Convert.ToDouble(distance), Convert.ToDouble(time), Convert.ToDouble(speed), currentUser.Weight);

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Biking).Id;
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);

                LinkForm.Link(parentForm, new Dashboard());
            }
        }
    }
}
