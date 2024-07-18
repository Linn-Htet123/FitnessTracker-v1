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
    /// <summary>
    /// Form for recording swimming activity.
    /// </summary>
    public partial class SwimmingActivity : Form
    {
        readonly private GoalController goalController = new GoalController();  // Controller for managing goals
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();  // Controller for managing activity types
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();  // Controller for managing activity histories

        private Dictionary<string, Label> errorLabels;  // Dictionary to store error labels for validation
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");  // Current logged-in user
        readonly private Form parentForm;  // Parent form reference

        /// <summary>
        /// Constructor for SwimmingActivity form.
        /// </summary>
        /// <param name="parentForm">Parent form reference.</param>
        public SwimmingActivity(Form parentForm)
        {
            InitializeComponent();  // Initializing components defined in the form
            InitializeErrorLabels();  // Initializing error labels for validation
            this.parentForm = parentForm;  // Assigning parent form reference
        }

        /// <summary>
        /// Initializes error labels for validation.
        /// </summary>
        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "laps", Lbl_error_laps },  // Error label for laps input
                { "timeTaken", Lbl_error_time },  // Error label for time taken input
                { "averageHeartRate", Lbl_error_heart_rate },  // Error label for average heart rate input
            };
        }

        /// <summary>
        /// Event handler for submit button click.
        /// </summary>
        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string laps = Txt_laps.Text;  // Getting laps input
            string time = Txt_time_taken.Text;  // Getting time taken input
            string heartRate = Txt_heart_rate.Text;  // Getting average heart rate input

            ClearLabels(errorLabels);  // Clearing previous validation error labels

            var validationResult = SwimmingValidation.ValidateSwimming(laps, time, heartRate);  // Validating inputs

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Rendering validation errors if any
                return;
            }

            var burnedCalories = CalculateSwimmingCalories(Convert.ToInt32(laps), Convert.ToDouble(time), Convert.ToDouble(heartRate), currentUser.Weight);  // Calculating burned calories

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);  // Updating current calories in goal controller

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Swimming).Id;  // Getting activity type ID for swimming
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);  // Creating activity history for swimming

                LinkForm.Link(parentForm, new Dashboard());  // Navigating back to dashboard
            }
        }
    }
}