using FitnessTracker.controllers;
using FitnessTracker.models;
using FitnessTracker.services;
using FitnessTracker.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static FitnessTracker.utils.ModalPopup;

namespace FitnessTracker.views
{
    public partial class Dashboard : Form
    {
        // Controllers for handling user data, goals, and activity histories
        readonly private UserController userController = new UserController();
        readonly private GoalController goalController = new GoalController();
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();

        // Constructor for Dashboard form
        public Dashboard()
        {
            InitializeComponent();
            LoadGreeting();  // Load greeting message based on current date
            LoadUserData();  // Load user-specific data like username, weight, height, and total burned calories
            LoadCaloriesRate();  // Load current goal progress and update UI elements accordingly
            LoadActivityLabels();  // Load recent activity labels
            LoadActivityChart();  // Load activity chart showing percentages of different activities
            this.Shown += Dashboard_Shown;  // Attach event handler to refresh data on form shown
        }

        // Event handler for when the Dashboard form is shown
        private void Dashboard_Shown(object sender, EventArgs e)
        {
            LoadUserData();  // Refresh user data
            LoadCaloriesRate();  // Refresh current goal progress
            LoadActivityLabels();  // Refresh recent activity labels
            LoadActivityChart();  // Refresh activity chart
        }

        // Load user-specific data into UI elements
        private void LoadUserData()
        {
            User user = StoreServices.GetState<User>("CurrentUser");  // Get current user from application state
            if (user != null)
            {
                Lbl_username.Text = user.Username;  // Display username
                Lbl_weight.Text = $"{user.Weight} kg";  // Display user's weight
                Lbl_height.Text = $"{user.Height} cm";  // Display user's height
                Lbl_burn.Text = $"{goalController.GetTotalCaloriesBurned()} cal";  // Display total calories burned
            }
        }

        // Reset display for goal progress UI elements
        private void ResetCaloriesRateDisplay()
        {
            Lbl_calories_rate.Text = $"0 / 0 cal";  // Reset displayed calories rate
            Prog_goal.Value = 0;  // Reset progress bar value
            Lbl_percent.Text = "0%";  // Reset percentage label
            Lbl_set_calories.Text = "Set a calorie goal";  // Display default message for setting calorie goal
            Lbl_message.Text = string.Empty;  // Clear additional message label
        }

        // Update progress bar and labels based on percentage
        private void UpdateProgressBarAndLabels(double percentage)
        {
            if (percentage > 100)
            {
                HandleExceedingGoalCase(percentage);  // Handle case where goal is exceeded
            }
            else
            {
                Prog_goal.Value = (int)Math.Round(percentage);  // Set progress bar value
                Lbl_percent.Text = $"{(int)Math.Round(percentage)} %";  // Display percentage label
                ClearMessageLabel();  // Clear additional message label
            }
        }

        // Handle UI updates for exceeding goal percentage
        private void HandleExceedingGoalCase(double percentage)
        {
            double exceedPercentage = percentage - 100;  // Calculate exceeded percentage
            Prog_goal.Value = 100;  // Set progress bar to maximum
            Lbl_percent.Text = "100%";  // Display 100% in percentage label
            Lbl_message.Text = $"You exceed more than your goal by {Math.Round(exceedPercentage, 2)}%, good job!";  // Display exceeding goal message
        }

        // Handle error case when calculating percentage
        private void HandlePercentageCalculationError(ArgumentException ex)
        {
            Lbl_calories_rate.Text = "Error calculating percentage";  // Display error message for percentage calculation
            Prog_goal.Value = 0;  // Reset progress bar
            Lbl_percent.Text = "0%";  // Reset percentage label
            Lbl_message.Text = string.Empty;  // Clear additional message label
            Console.WriteLine(ex.Message);  // Output error message to console
        }

        // Clear additional message label
        private void ClearMessageLabel()
        {
            Lbl_message.Text = string.Empty;  // Clear additional message label
        }

        // Load current goal progress and update UI elements
        private void LoadCaloriesRate()
        {
            var currentGoal = goalController.GetCurrentGoal();  // Get current goal from controller

            if (currentGoal == null)
            {
                ResetCaloriesRateDisplay();  // Reset UI elements if no current goal
                return;
            }

            double goalCalories = currentGoal.GoalCalories;  // Get goal calories
            double currentCalories = currentGoal.CurrentCalories;  // Get current calories

            Lbl_calories_rate.Text = $"{currentCalories} / {goalCalories} cal";  // Display current and goal calories

            if (currentGoal.IsComplete)
            {
                Lbl_set_calories.Text = "You completed goal, well done!";  // Display message for completed goal
            }
            else if (currentGoal.CurrentCalories == 0 && !currentGoal.IsComplete)
            {
                Lbl_set_calories.Text = "Start the progress!";  // Display message to start goal progress
            }
            else
            {
                Lbl_set_calories.Text = "Goal in progress, keep doing!";  // Display message for goal in progress
            }

            try
            {
                double percentage = CalculatePercentage.GetPercentage(currentCalories, goalCalories);  // Calculate percentage of goal progress
                UpdateProgressBarAndLabels(percentage);  // Update progress bar and labels based on percentage
            }
            catch (ArgumentException ex)
            {
                HandlePercentageCalculationError(ex);  // Handle error case when calculating percentage
            }
        }

        // Load greeting message based on current date
        private void LoadGreeting()
        {
            Lbl_greet.Text = Date.GetGreet(DateTime.Now);  // Display greeting message based on current date
        }

        // Logout user and navigate to login form
        private void Lbl_logout_Click(object sender, EventArgs e)
        {
            userController.Logout();  // Logout user
            LinkForm.Link(this, new Login());  // Navigate to login form
        }

        // Navigate to goal setting form
        private void Btn_link_setGoal_Click(object sender, EventArgs e)
        {
            if (goalController.HasIncompleteGoal())
            {
                WarningPopup("There is a goal you haven't complete, please complete it first");  // Display warning if there's an incomplete goal
                return;
            }
            LinkForm.Link(this, new Goal());  // Navigate to goal setting form
        }

        // Navigate to activities form
        private void Btn_link_activities_Click(object sender, EventArgs e)
        {
            if (!goalController.HasIncompleteGoal())
            {
                WarningPopup("Please set the goal first to make activities");  // Display warning if no goal set
                return;
            }
            LinkForm.Link(this, new Activities());  // Navigate to activities form
        }

        // Load recent activity labels
        private void LoadActivityLabels()
        {
            List<Dictionary<string, object>> activities = activityHistoriesController.GetActivityHistoriesByUser().Take(3).ToList();  // Get recent activities

            Lbl_no_recent.Visible = activities.Count == 0;  // Display message if no recent activities

            for (int i = 0; i < 3; i++)
            {
                if (i < activities.Count)
                {
                    string activityName = activities[i].ContainsKey("activity_name") ? activities[i]["activity_name"].ToString() : "";  // Get activity name
                    string caloriesBurned = activities[i].ContainsKey("burned_calories") ? activities[i]["burned_calories"].ToString() : "";  // Get burned calories

                    switch (i)
                    {
                        case 0:
                            UpdateLabel(Lbl_activity_name_1, activityName);  // Update label for first activity
                            UpdateLabel(Lbl_calories_burned_1, $"- {caloriesBurned} cal");  // Update label for calories burned
                            break;
                        case 1:
                            UpdateLabel(Lbl_activity_name_2, activityName);  // Update label for second activity
                            UpdateLabel(Lbl_calories_burned_2, $"- {caloriesBurned} cal");  // Update label for calories burned
                            break;
                        case 2:
                            UpdateLabel(Lbl_activity_name_3, activityName);  // Update label for third activity
                            UpdateLabel(Lbl_calories_burned_3, $"- {caloriesBurned} cal");  // Update label for calories burned
                            break;
                    }
                }
                else
                {
                    // Clear labels if fewer than 3 activities
                    switch (i)
                    {
                        case 0:
                            ClearLabels(Lbl_activity_name_1, Lbl_calories_burned_1);  // Clear labels for first activity
                            break;
                        case 1:
                            ClearLabels(Lbl_activity_name_2, Lbl_calories_burned_2);  // Clear labels for second activity
                            break;
                        case 2:
                            ClearLabels(Lbl_activity_name_3, Lbl_calories_burned_3);  // Clear labels for third activity
                            break;
                    }
                }
            }
        }

        // Update label text
        private void UpdateLabel(Label label, string text)
        {
            label.Text = text;  // Update label text
        }

        // Clear label text
        private void ClearLabels(Label nameLabel, Label caloriesLabel)
        {
            nameLabel.Text = "";  // Clear name label
            caloriesLabel.Text = "";  // Clear calories label
        }

        // Load activity chart showing percentages of different activities
        private void LoadActivityChart()
        {
            var activityCounts = activityHistoriesController.GetActivityCount();  // Get counts of different activities
            var totalActivities = activityCounts.Values.Sum();  // Calculate total activities

            ActivityChart.Series.Clear();  // Clear existing series in chart
            ActivityChart.ChartAreas[0].AxisY.Maximum = 100;  // Set maximum value for Y-axis

            ActivityChart.Series.Add(new Series());  // Add new series to chart
            ActivityChart.Series[0].ChartType = SeriesChartType.Column;  // Set chart type to column

            foreach (var activityName in activityCounts.Keys)
            {
                var count = activityCounts.ContainsKey(activityName) ? activityCounts[activityName] : 0;  // Get count of specific activity
                var percentage = totalActivities > 0 ? CalculatePercentage.GetPercentage(count, totalActivities) : 0;  // Calculate percentage of activity

                var series = ActivityChart.Series[0];  // Get reference to series
                series.Points.AddXY(activityName, percentage);  // Add data point to series
            }

            ActivityChart.ChartAreas[0].AxisX.Interval = 1;  // Set interval for X-axis
            ActivityChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;  // Disable major grid for X-axis
            ActivityChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;  // Disable major grid for Y-axis
            ActivityChart.Legends.Clear();  // Clear legends in chart

            // Hide or show the label based on totalActivities
            Lbl_no_activities.Visible = totalActivities == 0;
        }

        // Navigate to progress monitoring form
        private void Btn_progress_monitoring_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new MonitorProgress());  // Navigate to progress monitoring form
        }

        // Navigate to user profile form
        private void Btn_profile_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new UserProfile());  // Navigate to user profile form
        }
    }
}
