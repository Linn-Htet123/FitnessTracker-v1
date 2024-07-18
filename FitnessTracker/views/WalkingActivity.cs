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
    /// Form for recording walking activity.
    /// </summary>
    public partial class WalkingActivity : Form
    {
        readonly private GoalController goalController = new GoalController();  // Controller for goal-related actions
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();  // Controller for activity type actions
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();  // Controller for activity history actions

        private Dictionary<string, Label> errorLabels;  // Dictionary to store error labels for validation
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");  // Current logged-in user retrieved from state
        readonly private Form parentForm;  // Parent form reference for navigation

        /// <summary>
        /// Constructor for WalkingActivity form.
        /// </summary>
        /// <param name="parentForm">Parent form reference for navigation</param>
        public WalkingActivity(Form parentForm)
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
                { "steps", Lbl_error_steps },  // Error label for steps input
            };
        }

        /// <summary>
        /// Event handler for submit button click.
        /// </summary>
        private void Btn_submit_Click(object sender, EventArgs e)
        {
            string distance = Txt_distance.Text;  // Getting distance input
            string time = Txt_time_taken.Text;  // Getting time taken input
            string steps = Txt_steps.Text;  // Getting steps input

            ClearLabels(errorLabels);  // Clearing previous validation error labels

            var validationResult = WalkingValidation.ValidateWalking(steps, distance, time);  // Validating walking activity inputs

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Rendering validation errors if any
                return;
            }

            var burnedCalories = CalculateWalkingCalories(Convert.ToInt32(steps), Convert.ToDouble(distance), Convert.ToDouble(time), currentUser.Weight);  // Calculating calories burned during walking activity

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);  // Updating current calories for the user's goals

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Walking).Id;  // Getting activity type ID for walking
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);  // Creating activity history for walking activity

                LinkForm.Link(parentForm, new Dashboard());  // Navigating back to dashboard form
            }
        }
    }
}