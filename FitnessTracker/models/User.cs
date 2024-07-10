using FitnessTracker.models.interfaces;

namespace FitnessTracker.models
{
    public class User : IUser
    {
        // Private fields to encapsulate the data
        private readonly int user_id;
        private readonly string username;
        private readonly double weight;
        private readonly double height;
        private readonly double total_calories_burned;
        private bool isAuthenticated;


        // Public properties with only getters for encapsulation
        public int UserId => user_id;
        public string Username => username;
        public double Weight => weight;
        public double Height => height;
        public double TotalCaloriesBurned => total_calories_burned;
        public bool IsAuthenticated => isAuthenticated;

        // Constructor to initialize the user
        public User(int id, string username, double weight, double height, double totalCaloriesBurned = 0)
        {
            this.user_id = id;
            this.username = username;
            this.weight = weight;
            this.height = height;
            this.total_calories_burned = totalCaloriesBurned;
            this.isAuthenticated = false;
        }

        // Public methods to modify the internal state
        public void Authenticate()
        {
            this.isAuthenticated = true;
        }
    }
}
