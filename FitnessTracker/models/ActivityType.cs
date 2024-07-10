using FitnessTracker.models.interfaces;

namespace FitnessTracker.models
{
    public class ActivityType : IActivityType
    {
        // Private fields to encapsulate the data
        private readonly int id;
        private readonly string activityName;
        private readonly string metric1Name;
        private readonly string metric1Unit;
        private readonly string metric2Name;
        private readonly string metric2Unit;
        private readonly string metric3Name;
        private readonly string metric3Unit;

        // Public properties with only getters for encapsulation
        public int Id => id;
        public string ActivityName => activityName;
        public string Metric1Name => metric1Name;
        public string Metric1Unit => metric1Unit;
        public string Metric2Name => metric2Name;
        public string Metric2Unit => metric2Unit;
        public string Metric3Name => metric3Name;
        public string Metric3Unit => metric3Unit;

        // Constructor to initialize the activity type
        public ActivityType(int id, string activityName, string metric1Name, string metric1Unit,
            string metric2Name, string metric2Unit, string metric3Name, string metric3Unit)
        {
            this.id = id;
            this.activityName = activityName;
            this.metric1Name = metric1Name;
            this.metric1Unit = metric1Unit;
            this.metric2Name = metric2Name;
            this.metric2Unit = metric2Unit;
            this.metric3Name = metric3Name;
            this.metric3Unit = metric3Unit;
        }
    }
}
