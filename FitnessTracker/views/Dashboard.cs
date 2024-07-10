using FintnessTracker.controllers;
using FitnessTracker.controllers;
using FitnessTracker.models;
using FitnessTracker.services;
using FitnessTracker.utils;
using System;
using System.Windows.Forms;
using static FitnessTracker.utils.ModalPopup;

namespace FitnessTracker.views
{
    public partial class Dashboard : Form
    {
        readonly UserController userController = new UserController();
        readonly GoalController goalController = new GoalController();
        readonly private User user = StoreServices.GetState<User>("CurrentUser");

        public Dashboard()
        {
            InitializeComponent();
            LoadGreeting();
            LoadUserData();
            LoadCaloriesRate();
        }

        private void LoadUserData()
        {


            if (user != null && user.IsAuthenticated)
            {
                Lbl_username.Text = user.Username;
                Lbl_weight.Text = $"{user.Weight} kg";
                Lbl_height.Text = $"{user.Height} cm";
                Lbl_burn.Text = $"{goalController.GetTotalCaloriesBurned()} kcal";
            }
        }

        private void ResetCaloriesRateDisplay()
        {
            Lbl_calories_rate.Text = $"0 / 0 kcal";
            Prog_goal.Value = 0;
            Lbl_percent.Text = "0%";
            Lbl_set_calories.Text = "Set a calorie goal";
            Lbl_message.Text = string.Empty;
        }

        private void UpdateProgressBarAndLabels(double percentage)
        {
            if (percentage > 100)
            {
                HandleExceedingGoalCase(percentage);
            }
            else
            {
                Prog_goal.Value = (int)Math.Round(percentage);
                Lbl_percent.Text = $"{(int)Math.Round(percentage)} %";
                ClearMessageLabel();
            }
        }

        private void HandleExceedingGoalCase(double percentage)
        {
            double exceedPercentage = percentage - 100;
            Prog_goal.Value = 100;
            Lbl_percent.Text = "100%";
            Lbl_message.Text = $"You exceed more than your goal by {Math.Round(exceedPercentage, 2)}%, good job!";
        }

        private void HandlePercentageCalculationError(ArgumentException ex)
        {
            Lbl_calories_rate.Text = "Error calculating percentage";
            Prog_goal.Value = 0;
            Lbl_percent.Text = "0%";
            Lbl_message.Text = string.Empty;
            Console.WriteLine(ex.Message);
        }

        private void ClearMessageLabel()
        {
            Lbl_message.Text = string.Empty;
        }


        private void LoadCaloriesRate()
        {
            var currentGoal = goalController.GetCurrentGoal();

            if (currentGoal == null)
            {
                ResetCaloriesRateDisplay();
                return;
            }

            double goalCalories = currentGoal.GoalCalories;
            double currentCalories = currentGoal.CurrentCalories;

            Lbl_calories_rate.Text = $"{currentCalories} / {goalCalories} kcal";
            if (currentGoal.IsComplete)
            {
                Lbl_set_calories.Text = "You completed goal, well done!";
            }
            else if (currentGoal.CurrentCalories == 0 && !currentGoal.IsComplete)
            {
                Lbl_set_calories.Text = "Start the progress!";
            }
            else
            {
                Lbl_set_calories.Text = "Goal in progress, keep doing!";
            }


            try
            {
                double percentage = CalculatePercentage.GetPercentage(currentCalories, goalCalories);

                UpdateProgressBarAndLabels(percentage);
            }
            catch (ArgumentException ex)
            {
                HandlePercentageCalculationError(ex);
            }
        }


        private void LoadGreeting()
        {
            Lbl_greet.Text = Date.GetGreet(DateTime.Now);
        }

        private void Lbl_logout_Click(object sender, EventArgs e)
        {
            userController.Logout();
            LinkForm.Link(this, new Login());
        }

        private void Btn_link_setGoal_Click(object sender, EventArgs e)
        {
            if (goalController.HasIncompleteGoal())
            {
                WarningPopup("There is a goal you haven't complete, please complete it first");
                return;
            }
            LinkForm.Link(this, new Goal());
        }

        private void Btn_link_activities_Click(object sender, EventArgs e)
        {
            if (!goalController.HasIncompleteGoal())
            {
                WarningPopup("Please set the goal first to make activities");
                return;
            }
            LinkForm.Link(this, new Activities());
        }


    }
}
