using FitnessTracker.controllers;
using FitnessTracker.utils;
using FitnessTracker.validations;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FitnessTracker.utils.LabelUtils;
using static FitnessTracker.utils.ModalPopup;
using static FitnessTracker.utils.PasswordUtils;
using static FitnessTracker.utils.TextBoxUtils;

namespace FitnessTracker.views
{
    public partial class Signup : Form
    {
        private readonly UserController userController = new UserController();

        private Dictionary<string, Label> errorLabels;
        private List<TextBox> textBoxes;

        public Signup()
        {
            InitializeComponent();
            InitializeErrorLabels();
            InitializeTextBoxes();
        }

        // Initializes error labels for validation
        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "username", Lbl_error_username },  // Error label for username
                { "password", Lbl_error_password },  // Error label for password
                { "confirmPassword", Lbl_error_confirm_password },  // Error label for confirm password
                { "weight", Lbl_error_weight },  // Error label for weight
                { "height", Lbl_error_height },  // Error label for height
            };
        }

        // Initializes textboxes for input
        private void InitializeTextBoxes()
        {
            textBoxes = new List<TextBox>
            {
               Txt_username,  // Username textbox
               Txt_password,  // Password textbox
               Txt_confirm_password,  // Confirm password textbox
               Txt_weight,  // Weight textbox
               Txt_height  // Height textbox
            };
        }

        // Handles signup button click event
        private void Btn_signup_Click(object sender, EventArgs e)
        {
            string username = Txt_username.Text.Trim();  // Gets username input
            string password = Txt_password.Text.Trim();  // Gets password input
            string confirmPassword = Txt_confirm_password.Text.Trim();  // Gets confirm password input
            string weightText = Txt_weight.Text.Trim();  // Gets weight input
            string heightText = Txt_height.Text.Trim();  // Gets height input

            ClearLabels(errorLabels);  // Clears previous validation error labels

            var validationResult = UserValidator.ValidateSignup(username, password, confirmPassword, weightText, heightText);  // Validates user inputs

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);  // Renders validation errors if any
                return;
            }

            // Converts weight and height inputs to double
            if (double.TryParse(weightText, out double weight) && double.TryParse(heightText, out double height))
            {
                if (userController.Register(username, password, weight, height))  // Registers user if inputs are valid
                {
                    InfoPopup("Registration successful!");  // Shows success message
                    LinkForm.Link(this, new Dashboard());  // Links to the dashboard
                }
            }
            else
            {
                WarningPopup("Invalid weight or height format.");  // Shows warning message for invalid inputs
            }

            ClearTextBoxes(textBoxes);  // Clears all textboxes
        }

        // Handles login link label click event
        private void Lbl_link_login_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new Login());  // Links to the login form
        }

        // Handles password show/hide checkbox change event
        private void Chk_show_pasword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordShowHide(Chk_show_pasword, Txt_password);  // Shows or hides password based on checkbox state
        }

        // Handles confirm password show/hide checkbox change event
        private void Chk_confirm_password_show_CheckedChanged(object sender, EventArgs e)
        {
            PasswordShowHide(Chk_confirm_password_show, Txt_confirm_password);  // Shows or hides confirm password based on checkbox state
        }
    }
}
