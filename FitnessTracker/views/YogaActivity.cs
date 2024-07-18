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
    /// Form for recording yoga activity.
    /// </summary>
    public partial class YogaActivity : Form
    {
        readonly private GoalController goalController = new GoalController();  // Controller for goal-related actions
        readonly private ActivityTypeController activityTypeController = new ActivityTypeController();  // Controller for activity type actions
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();  // Controller for activity history actions

        private Dictionary<string, Label> errorLabels;  // Dictionary to store error labels for validation
        readonly private User currentUser = StoreServices.GetState<User>("CurrentUser");  // Current logged-in user retrieved from state
        readonly private Form parentForm;  // Parent form reference for navigation

        /// <summary>
        /// Constructor for YogaActivity form.
        /// </summary>
        /// <param name="parentForm">Parent form reference for navigation</param>
        public YogaActivity(Form parentForm)
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
                { "duration", Lbl_error_time },  // Error label for duration input
                { "averageHeartRate", Lbl_error_heart_rate },  // Error label for heart rate input
                { "intensityFactor", Lbl_error_intensity_factor },  // Error label for intensity factor input
            };
        }

        /// <summary>
        /// Event handler for submit button click.
        /// </summary>
        private void Btn_submit_Click(object sender, EventArgs e)
        {
            string heartRate = Txt_heart_rate.Text;  // Getting heart rate input
            string duration = Txt_time_taken.Text;  // Getting duration input
            string intensityFactor = Txt_intensity_factor.Text;  // Getting intensity factor input

            ClearLabels(errorLabels);  // Clearing previous validation error labels

            var validationResult = YogaValidation.ValidateYoga(duration, heartRate, intensityFactor);  // Validating yoga activity inputs

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Rendering validation errors if any
                return;
            }

            var burnedCalories = CalculateYogaCalories(Convert.ToDouble(duration), Convert.ToDouble(heartRate), Convert.ToDouble(intensityFactor), currentUser.Weight);  // Calculating calories burned during yoga activity

            bool isUpdated = goalController.UpdateCurrentCalories(burnedCalories);  // Updating current calories for the user's goals

            if (isUpdated)
            {
                int activityTypeId = activityTypeController.GetActivityType(ActivityTypesEnum.Yoga).Id;  // Getting activity type ID for yoga
                activityHistoriesController.CreateActivityHistories(activityTypeId, burnedCalories);  // Creating activity history for yoga activity

                LinkForm.Link(parentForm, new Dashboard());  // Navigating back to dashboard form
            }
        }
    }
}