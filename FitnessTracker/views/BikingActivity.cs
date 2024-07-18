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
        // Controllers for handling goals, activity types, and activity histories
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();

        // Dictionary to map error types to error labels on the form
        private Dictionary<string, Label> errorLabels;

        // Current user retrieved from application state
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");

        // Reference to the parent form for navigation
        readonly private Form parentForm;

        // Constructor for the BikingActivity form
        public BikingActivity(Form parentForm)
        {
            InitializeComponent();
            InitializeErrorLabels();  // Initialize error labels dictionary
            this.parentForm = parentForm;  // Set parent form reference
        }

        // Initialize error labels dictionary mapping error types to labels on the form
        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "distance", Lbl_error_distance },  // Map 'distance' error to Lbl_error_distance label
                { "timeTaken", Lbl_error_time },      // Map 'timeTaken' error to Lbl_error_time label
                { "speed", Lbl_error_speed },         // Map 'speed' error to Lbl_error_speed label
            };
        }

        // Event handler for the submit button click
        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string distance = Txt_distance.Text;     // Get distance input from text box
            string time = Txt_time_taken.Text;       // Get time taken input from text box
            string speed = Txt_speed.Text;           // Get speed input from text box

            ClearLabels(errorLabels);  // Clear previous error labels

            var validationResult = BikingValidation.ValidateBiking(distance, time, speed);  // Validate biking activity inputs

            // If validation fails, render validation errors on the form
            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }

            // Calculate burned calories based on biking activity inputs and current user's weight
            var burnedCalories = CalculateBikingCalories(Convert.ToDouble(distance), Convert.ToDouble(time), Convert.ToDouble(speed), currentUser.Weight);

            // Update current calories in the user's goal
            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);

            // If calories updated successfully, log the biking activity in activity histories
            if (isUpdated)
            {
                // Get activity type ID for biking
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Biking).Id;

                // Create activity history for biking with burned calories
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);

                // Navigate back to the dashboard form after logging activity
                LinkForm.Link(parentForm, new Dashboard());
            }
        }
    }
}
