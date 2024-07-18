using FitnessTracker.controllers;
using FitnessTracker.models;
using FitnessTracker.services;
using FitnessTracker.utils;
using FitnessTracker.validations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FitnessTracker.utils.LabelUtils;
using static FitnessTracker.utils.ModalPopup;

namespace FitnessTracker.views
{
    /// <summary>
    /// Form for displaying and updating user profile information.
    /// </summary>
    public partial class UserProfile : Form
    {
        private readonly User user = StoreServices.GetState<User>("CurrentUser");  // Current logged-in user retrieved from state
        private readonly UserController userController = new UserController();  // Controller for user-related actions
        private readonly GoalController goalController = new GoalController(); // Controller for goal-related actions
        private Dictionary<string, Label> errorLabels;  // Dictionary to store error labels for validation

        /// <summary>
        /// Constructor for UserProfile form.
        /// </summary>
        public UserProfile()
        {
            InitializeComponent();  // Initializing components defined in the form
            LoadGreeting();  // Loading greeting message
            LoadUserData();  // Loading user data into UI components
            InitializeErrorLabels();  // Initializing error labels for validation
        }

        /// <summary>
        /// Initializes error labels for validation.
        /// </summary>
        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "weight", Lbl_error_weight },  // Error label for weight input
                { "height", Lbl_error_height },  // Error label for height input
            };
        }

        /// <summary>
        /// Loads user data into UI components.
        /// </summary>
        private void LoadUserData()
        {
            Lbl_username.Text = user.Username;  // Displaying username
            Lbl_current_weight.Text = $"{user.Weight} kg";  // Displaying current weight
            Lbl_current_height.Text = $"{user.Height} cm";  // Displaying current height
            Txt_weight.Text = user.Weight.ToString();  // Setting weight in text box
            Txt_height.Text = user.Height.ToString();  // Setting height in text box
            Lbl_total_calories_burned.Text = $"{goalController.GetTotalCaloriesBurned()} cal";  // Display total calories burned
        }

        /// <summary>
        /// Loads greeting message based on current date.
        /// </summary>
        private void LoadGreeting()
        {
            Lbl_greet.Text = Date.GetGreet(DateTime.Now);  // Displaying greeting message based on current date
        }

        /// <summary>
        /// Event handler for back button click.
        /// </summary>
        private void Btn_back_Click(object sender, System.EventArgs e)
        {
            LinkForm.Link(this, new Dashboard());  // Navigating back to dashboard form
        }

        /// <summary>
        /// Event handler for logout button click.
        /// </summary>
        private void Btn_logout_Click(object sender, EventArgs e)
        {
            userController.Logout();  // Logging out current user
            LinkForm.Link(this, new Login());  // Navigating to login form
        }

        /// <summary>
        /// Event handler for update button click.
        /// </summary>
        private void Btn_update_Click(object sender, EventArgs e)
        {
            string weightText = Txt_weight.Text.Trim();  // Getting weight input
            string heightText = Txt_height.Text.Trim();  // Getting height input
            ClearLabels(errorLabels);  // Clearing previous validation error labels

            var validationResult = UserValidator.ValidateProfileUpdate(weightText, heightText);  // Validating weight and height inputs

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Rendering validation errors if any
                return;
            }

            DialogResult isUpdate = ConfirmationPopup("Are you sure you want to update profile?");  // Confirmation dialog for profile update

            if (isUpdate == DialogResult.Yes)
            {
                if (userController.UpdateWeightAndHeight(Convert.ToDouble(weightText), Convert.ToDouble(heightText)))
                {
                    InfoPopup("User updated successfully");  // Showing success message
                    LinkForm.Link(this, new Dashboard());  // Navigating back to dashboard
                }
                else
                {
                    WarningPopup("Failed to update user.");  // Showing warning message if update fails
                }
            }
        }
    }
}