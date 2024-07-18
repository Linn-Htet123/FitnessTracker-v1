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
    public partial class RunningActivity : Form
    {
        readonly private GoalController goalController = new GoalController();  // Controller for managing goals
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();  // Controller for managing activity types
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();  // Controller for managing activity histories

        private Dictionary<string, Label> errorLabels;  // Dictionary to store error labels for validation
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");  // Current logged-in user
        readonly private Form parentForm;  // Parent form reference

        /// <summary>
        /// Constructor for RunningActivity form.
        /// </summary>
        /// <param name="parentForm">Parent form reference.</param>
        public RunningActivity(Form parentForm)
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
                { "distance", Lbl_error_distance },  // Error label for distance input
                { "timeTaken", Lbl_error_time },  // Error label for time taken input
                { "speed", Lbl_error_speed },  // Error label for speed input
            };
        }

        /// <summary>
        /// Event handler for submit button click.
        /// </summary>
        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string distance = Txt_distance.Text;  // Getting distance input
            string time = Txt_time_taken.Text;  // Getting time taken input
            string speed = Txt_speed.Text;  // Getting speed input

            ClearLabels(errorLabels);  // Clearing previous validation error labels

            var validationResult = RunningValidation.ValidateRunning(distance, time, speed);  // Validating inputs

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Rendering validation errors if any
                return;
            }

            var burnedCalories = CalculateRunningCalories(Convert.ToDouble(distance), Convert.ToDouble(time), Convert.ToDouble(speed), currentUser.Weight);  // Calculating burned calories

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);  // Updating current calories in goal controller

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Running).Id;  // Getting activity type ID for running
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);  // Creating activity history for running

                LinkForm.Link(parentForm, new Dashboard());  // Navigating back to dashboard
            }
        }

    }
}
