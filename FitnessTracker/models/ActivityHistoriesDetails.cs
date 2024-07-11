using FitnessTracker.models.interfaces;
using System;

namespace FitnessTracker.models
{
    public class ActivityHistoriesDetails : IActivityHistories, IActivityType
    {
        // Private fields to encapsulate the data
        private readonly int id;
        private readonly int activity_type_id;
        private readonly int user_id;
        private readonly double burned_calories;
        private readonly DateTime created_at;

        private readonly string activity_name;
        private readonly string metric1_name;
        private readonly string metric1_unit;
        private readonly string metric2_name;
        private readonly string metric2_unit;
        private readonly string metric3_name;
        private readonly string metric3_unit;

        // Public properties with only getters for encapsulation
        public int Id => id;
        public int ActivityTypeId => activity_type_id;
        public int UserId => user_id;
        public double BurnedCalories => burned_calories;
        public DateTime CreatedAt => created_at;

        public string ActivityName => activity_name;
        public string Metric1Name => metric1_name;
        public string Metric1Unit => metric1_unit;
        public string Metric2Name => metric2_name;
        public string Metric2Unit => metric2_unit;
        public string Metric3Name => metric3_name;
        public string Metric3Unit => metric3_unit;

        // Constructor to initialize the fields
        public ActivityHistoriesDetails(int id, int activityTypeId, int userId, double burnedCalories, DateTime createdAt,
                                        string activityName, string metric1Name, string metric1Unit,
                                        string metric2Name, string metric2Unit, string metric3Name, string metric3Unit)
        {
            this.id = id;
            this.activity_type_id = activityTypeId;
            this.user_id = userId;
            this.burned_calories = burnedCalories;
            this.created_at = createdAt;

            this.activity_name = activityName;
            this.metric1_name = metric1Name;
            this.metric1_unit = metric1Unit;
            this.metric2_name = metric2Name;
            this.metric2_unit = metric2Unit;
            this.metric3_name = metric3Name;
            this.metric3_unit = metric3Unit;
        }
    }
}
