using FintnessTracker.controllers;
using FitnessTracker.controllers;
using FitnessTracker.models;
using FitnessTracker.services;
using FitnessTracker.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static FitnessTracker.utils.ModalPopup;

namespace FitnessTracker.views
{
    public partial class Dashboard : Form
    {
        readonly private UserController userController = new UserController();
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();
        readonly private User user = StoreServices.GetState<User>("CurrentUser");

        public Dashboard()
        {
            InitializeComponent();
            LoadGreeting();
            LoadUserData();
            LoadCaloriesRate();
            LoadActivityLabels();
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

        private void LoadActivityLabels()
        {
            List<Dictionary<string, object>> activities = activityHistoriesController.GetActivityHistoriesByUser().Take(3).ToList();


            Lbl_no_recent.Visible = activities.Count == 0;


            for (int i = 0; i < 3; i++)
            {
                if (i < activities.Count)
                {
                    string activityName = activities[i].ContainsKey("activity_name") ? activities[i]["activity_name"].ToString() : "";
                    string caloriesBurned = activities[i].ContainsKey("burned_calories") ? activities[i]["burned_calories"].ToString() : "";

                    switch (i)
                    {
                        case 0:
                            UpdateLabel(Lbl_activity_name_1, activityName);
                            UpdateLabel(Lbl_calories_burned_1, $"- {caloriesBurned} kcal");
                            break;
                        case 1:
                            UpdateLabel(Lbl_activity_name_2, activityName);
                            UpdateLabel(Lbl_calories_burned_2, $"- {caloriesBurned} kcal");
                            break;
                        case 2:
                            UpdateLabel(Lbl_activity_name_3, activityName);
                            UpdateLabel(Lbl_calories_burned_3, $"- {caloriesBurned} kcal");
                            break;
                    }
                }
                else
                {
                    // Clear labels if fewer than 3 activities
                    switch (i)
                    {
                        case 0:
                            ClearLabels(Lbl_activity_name_1, Lbl_calories_burned_1);
                            break;
                        case 1:
                            ClearLabels(Lbl_activity_name_2, Lbl_calories_burned_2);
                            break;
                        case 2:
                            ClearLabels(Lbl_activity_name_3, Lbl_calories_burned_3);
                            break;
                    }
                }
            }
        }

        private void UpdateLabel(Label label, string text)
        {
            label.Text = text;
        }

        private void ClearLabels(Label nameLabel, Label caloriesLabel)
        {
            nameLabel.Text = "";
            caloriesLabel.Text = "";
        }

        private string FormatActivityLabel(Dictionary<string, object> activity)
        {
            return $"{activity["activity_name"]}\t {activity["burned_calories"]} kcal";
        }

    }
}
