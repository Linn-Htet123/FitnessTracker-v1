using FintnessTracker.controllers;
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
    public partial class Login : Form
    {
        private readonly UserController userController = new UserController();
        private Dictionary<string, Label> errorLabels;
        private List<TextBox> textBoxes;
        private int loginAttempts = 0;
        private const int MaxLoginAttempts = 3;
        private const int LockoutTime = 30;
        private CountdownTimer lockoutTimer;

        public Login()
        {
            InitializeComponent();
            InitializeErrorLabels();
            InitializeTextBoxes();
            InitializeLockoutTimer();
        }
        private void InitializeLockoutTimer()
        {
            lockoutTimer = new CountdownTimer(LockoutTime);
            lockoutTimer.Tick += OnLockoutTick;
            lockoutTimer.Completed += OnLockoutCompleted;
        }

        private void OnLockoutTick(int remainingTime)
        {
            Lbl_lockout.Text = $"Too many attempts. Try again in {remainingTime} seconds.";
        }

        private void OnLockoutCompleted()
        {
            Btn_login.Enabled = true;
            Txt_username.Enabled = true;
            Txt_password.Enabled = true;
            Btn_login.BackColor = Color.FromArgb(0, 0, 64);
            Lbl_lockout.Text = string.Empty;
            loginAttempts = 0;
        }

        private void InitializeErrorLabels()
        {
            errorLabels = new Dictionary<string, Label>
            {
                { "username", Lbl_error_username },
                { "password", Lbl_error_password },
            };
        }

        private void InitializeTextBoxes()
        {
            textBoxes = new List<TextBox>
            {
               Txt_username,
               Txt_password
            };
        }
        private void DisableLogin()
        {
            Btn_login.Enabled = false;
            Txt_username.Enabled = false;
            Txt_password.Enabled = false;
            Btn_login.BackColor = Color.Gray;
            lockoutTimer.Start();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string username = Txt_username.Text.Trim();
            string password = Txt_password.Text.Trim();

            ClearLabels(errorLabels);

            var validationResult = UserValidator.ValidateLogin(username, password);
            if (!validationResult.IsValid)
            {
                RenderValidationErrors.RenderErrors(errorLabels, validationResult);
                return;
            }

            if (userController.Login(username, password))
            {
                InfoPopup("Login successful!");
                LinkForm.Link(this, new Dashboard());
            }
            else
            {
                loginAttempts++;
                WarningPopup("Invalid username or password.");
                if (loginAttempts >= MaxLoginAttempts)
                {
                    DisableLogin();
                }
            }

            ClearTextBoxes(textBoxes);
        }

        private void Chk_show_pasword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordShowHide(Chk_show_pasword, Txt_password);
        }

        private void Lbl_link_signup_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new Signup());
        }
    }
}
