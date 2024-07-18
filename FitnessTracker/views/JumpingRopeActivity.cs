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
    /// Form for recording jumping rope activity.
    /// </summary>
    public partial class JumpingRopeActivity : Form
    {
        readonly private GoalController goalController = new GoalController();  // Controller for managing goals
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();  // Controller for managing activity types
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();  // Controller for managing activity histories

        private Dictionary<string, Label> errorLabels;  // Dictionary to store error labels for validation
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");  // Current logged-in user
        readonly private Form parentForm;  // Parent form reference

        /// <summary>
        /// Constructor for JumpingRopeActivity form.
        /// </summary>
        /// <param name="parentForm">Parent form reference.</param>
        public JumpingRopeActivity(Form parentForm)
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
                { "jumps", Lbl_error_jumps },  // Error label for jumps input
                { "duration", Lbl_error_time },  // Error label for time taken input
                { "intensityFactor", Lbl_error_intensity_factor },  // Error label for intensity factor input
            };
        }

        /// <summary>
        /// Event handler for submit button click.
        /// </summary>
        private void Btn_submit_Click(object sender, System.EventArgs e)
        {
            string jumps = Txt_jumps.Text;  // Getting jumps input
            string time = Txt_time_taken.Text;  // Getting time taken input
            string intensityFactor = Txt_intensity_factor.Text;  // Getting intensity factor input

            ClearLabels(errorLabels);  // Clearing previous validation error labels

            var validationResult = JumpingRopeValidation.ValidateJumpingRope(jumps, time, intensityFactor);  // Validating inputs

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Rendering validation errors if any
                return;
            }

            var burnedCalories = CalculateJumpingRopeCalories(Convert.ToInt32(jumps), Convert.ToDouble(time), Convert.ToDouble(intensityFactor), currentUser.Weight);  // Calculating burned calories

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);  // Updating current calories in goal controller

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.JumpingRope).Id;  // Getting activity type ID for jumping rope
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);  // Creating activity history for jumping rope

                LinkForm.Link(parentForm, new Dashboard());  // Navigating back to dashboard
            }
        }
    }
}
