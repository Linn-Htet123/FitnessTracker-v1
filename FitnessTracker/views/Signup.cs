using FintnessTracker.controllers;
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

        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "username", Lbl_error_username },
                { "password", Lbl_error_password },
                { "confirmPassword", Lbl_error_confirm_password },
                { "weight", Lbl_error_weight },
                { "height", Lbl_error_height },
            };
        }

        private void InitializeTextBoxes()
        {
            textBoxes = new List<TextBox>
            {
               Txt_username,
               Txt_password,
               Txt_confirm_password,
               Txt_weight,
               Txt_height
            };
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            string username = Txt_username.Text.Trim();
            string password = Txt_password.Text.Trim();
            string confirmPassword = Txt_confirm_password.Text.Trim();
            string weightText = Txt_weight.Text.Trim();
            string heightText = Txt_height.Text.Trim();

            ClearLabels(errorLabels);

            var validationResult = UserValidator.ValidateSignup(username, password, confirmPassword, weightText, heightText);

            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }

            if (double.TryParse(weightText, out double weight) && double.TryParse(heightText, out double height))
            {
                if (userController.Register(username, password, weight, height))
                {
                    InfoPopup("Registration successful!");
                    LinkForm.Link(this, new Dashboard());
                }
            }
            else
            {
                WarningPopup("Invalid weight or height format.");
            }

            ClearTextBoxes(textBoxes);
        }

        private void Lbl_link_login_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new Login());
        }

        private void Chk_show_pasword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordShowHide(Chk_show_pasword, Txt_password);
        }

        private void Chk_confirm_password_show_CheckedChanged(object sender, EventArgs e)
        {
            PasswordShowHide(Chk_confirm_password_show, Txt_confirm_password);
        }
    }
}
