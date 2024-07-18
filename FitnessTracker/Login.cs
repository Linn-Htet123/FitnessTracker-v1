using FitnessTracker.controllers;
using FitnessTracker.helpers;
using FitnessTracker.utils;
using FitnessTracker.validations;
using FitnessTracker.views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static FitnessTracker.utils.LabelUtils;
using static FitnessTracker.utils.ModalPopup;
using static FitnessTracker.utils.PasswordUtils;
using static FitnessTracker.utils.TextBoxUtils;

namespace FitnessTracker
{
    /// <summary>
    /// Form for user login.
    /// </summary>
    public partial class Login : Form
    {
        private readonly UserController userController = new UserController();  // Controller for user-related actions
        private Dictionary<string, Label> errorLabels;  // Dictionary to store error labels for validation
        private List<TextBox> textBoxes;  // List to store textboxes for operations
        private int loginAttempts = 0;  // Counter for login attempts
        private const int MaxLoginAttempts = 3;  // Maximum allowed login attempts
        private const int LockoutTime = 30;  // Lockout time in seconds
        private CountdownTimer lockoutTimer;  // Timer for lockout countdown

        /// <summary>
        /// Constructor for the Login form.
        /// </summary>
        public Login()
        {
            InitializeComponent();  // Initializing components defined in the form
            InitializeErrorLabels();  // Initializing error labels for validation
            InitializeTextBoxes();  // Initializing textboxes for operations
            InitializeLockoutTimer();  // Initializing lockout timer
        }

        /// <summary>
        /// Initializes the lockout timer.
        /// </summary>
        private void InitializeLockoutTimer()
        {
            lockoutTimer = new CountdownTimer(LockoutTime);  // Creating a new countdown timer with lockout time
            lockoutTimer.Tick += OnLockoutTick;  // Assigning event handler for timer tick
            lockoutTimer.Completed += OnLockoutCompleted;  // Assigning event handler for timer completion
        }

        /// <summary>
        /// Event handler for lockout timer tick.
        /// </summary>
        /// <param name="remainingTime">Remaining time in seconds</param>
        private void OnLockoutTick(int remainingTime)
        {
            Lbl_lockout.Text = $"Too many attempts. Try again in {remainingTime} seconds.";  // Updating lockout label with remaining time
        }

        /// <summary>
        /// Event handler for lockout timer completion.
        /// </summary>
        private void OnLockoutCompleted()
        {
            Btn_login.Enabled = true;  // Enabling login button
            Txt_username.Enabled = true;  // Enabling username textbox
            Txt_password.Enabled = true;  // Enabling password textbox
            Btn_login.BackColor = Color.FromArgb(0, 0, 64);  // Resetting login button background color
            Lbl_lockout.Text = string.Empty;  // Clearing lockout label
            loginAttempts = 0;  // Resetting login attempts counter
        }

        /// <summary>
        /// Initializes error labels for validation.
        /// </summary>
        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "username", Lbl_error_username },  // Error label for username input
                { "password", Lbl_error_password },  // Error label for password input
            };
        }

        /// <summary>
        /// Initializes textboxes for operations.
        /// </summary>
        private void InitializeTextBoxes()
        {
            textBoxes = new List<TextBox>
            {
               Txt_username,  // Username textbox
               Txt_password  // Password textbox
            };
        }

        /// <summary>
        /// Disables login functionality temporarily.
        /// </summary>
        private void DisableLogin()
        {
            Btn_login.Enabled = false;  // Disabling login button
            Txt_username.Enabled = false;  // Disabling username textbox
            Txt_password.Enabled = false;  // Disabling password textbox
            Btn_login.BackColor = Color.Gray;  // Changing login button background color
            lockoutTimer.Start();  // Starting lockout timer
        }

        /// <summary>
        /// Event handler for login button click.
        /// </summary>
        private void Btn_login_Click(object sender, EventArgs e)
        {
            string username = Txt_username.Text.Trim();  // Getting username input
            string password = Txt_password.Text.Trim();  // Getting password input

            ClearLabels(errorLabels);  // Clearing previous validation error labels

            var validationResult = UserValidator.ValidateLogin(username, password);  // Validating login credentials

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Rendering validation errors if any
                return;
            }

            if (userController.Login(username, password))
            {
                InfoPopup("Login successful!");  // Showing success message
                LinkForm.Link(this, new Dashboard());  // Navigating to dashboard form
            }
            else
            {
                loginAttempts++;  // Incrementing login attempts
                WarningPopup("Invalid username or password.");  // Showing warning message for invalid credentials
                if (loginAttempts >= MaxLoginAttempts)
                {
                    DisableLogin();  // Disabling login after maximum attempts reached
                }
            }

            ClearTextBoxes(textBoxes);  // Clearing textboxes after login attempt
        }

        /// <summary>
        /// Event handler for password visibility toggle checkbox.
        /// </summary>
        private void Chk_show_pasword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordShowHide(Chk_show_pasword, Txt_password);  // Toggling password visibility
        }

        /// <summary>
        /// Event handler for signup link label click.
        /// </summary>
        private void Lbl_link_signup_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new Signup());  // Navigating to signup form
        }
    }
}