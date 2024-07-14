using FitnessTracker.controllers;
using FitnessTracker.utils;
using System;
using System.Windows.Forms;

namespace FitnessTracker.views
{
    public partial class MonitorProgress : Form
    {
        readonly private ActivityHistoriesController activityHistoriesController = new ActivityHistoriesController();
        readonly private GoalController goalController = new GoalController();

        public MonitorProgress()
        {
            InitializeComponent();
            LoadtotalGoalsAchievement();
            double totalCaloriesForToday = activityHistoriesController.GetDailyCaloriesBurned();
            UpdateTotalCaloriesLabel((double)totalCaloriesForToday, $"(today)");
            LoadActivityHistories();
        }

        private void LoadtotalGoalsAchievement()
        {
            int totalCounts = goalController.GetTotalAchievementGoals();
            Lbl_total_goals.Text = totalCounts.ToString();
        }

        private void LoadActivityHistories()
        {
            var activities = activityHistoriesController.GetActivityHistoriesByUser();
            int count = 0;
            foreach (var activity in activities)
            {
                count++;
                string number = count.ToString();
                string date = Convert.ToDateTime(activity["created_at"]).ToString("dd, MMM yyyy");
                string name = activity["activity_name"].ToString();
                string totalBurned = activity["burned_calories"].ToString() + " cal";

                Grid_activity_histories.Rows.Add(number, date, name, totalBurned);
            }
        }
        private void UpdateTotalCaloriesLabel(double totalCalories, string lbl)
        {
            // Set the main label text
            Lbl_total_calories.Text = $"{totalCalories} kcal";
            Lbl_day_msg.Text = lbl;
        }

        private void Btn_today_Click(object sender, System.EventArgs e)
        {
            double totalCaloriesForToday = activityHistoriesController.GetDailyCaloriesBurned();
            UpdateTotalCaloriesLabel((double)totalCaloriesForToday, "(today)");
        }

        private void Btn_filter_Click(object sender, EventArgs e)
        {
            // Get selected dates from DateTimePicker controls
            DateTime startDate = Date_from.Value.Date;  // Get the Date part without time
            DateTime endDate = Date_to.Value.Date.AddDays(1).AddSeconds(-1);  // Get end of the day

            // Example of using activityHistoriesController.GetDateRangeCaloriesBurned method
            double totalCaloriesForDateRange = activityHistoriesController.GetDateRangeCaloriesBurned(startDate, endDate);
            UpdateTotalCaloriesLabel((double)totalCaloriesForDateRange, $"({startDate.ToString("dd, MM yyyy")} - {endDate.ToString("dd, MM yyyy")})");

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            LinkForm.Link(this, new Dashboard());
        }
    }
}
