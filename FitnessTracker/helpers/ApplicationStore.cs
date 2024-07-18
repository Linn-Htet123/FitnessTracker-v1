using System.Collections.Generic;

namespace FitnessTracker.helpers
{
    public class ApplicationStore
    {
        private static ApplicationStore _instance;
        private readonly Dictionary<string, object> _states;

        // Private constructor to ensure singleton pattern
        private ApplicationStore()
        {
            _states = new Dictionary<string, object>(); // Initializes the dictionary to store states
        }

        public static ApplicationStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApplicationStore(); // Creates a new instance if one does not already exist
                }
                return _instance; // Returns the singleton instance
            }
        }

        // Method to set or update a state
        public void SetState(string key, object state)
        {
            _states[key] = state; // Adds or updates the state with the specified key
        }

        // Method to get a state
        public T GetState<T>(string key)
        {
            if (_states.ContainsKey(key)) // Checks if the key exists in the dictionary
            {
                object value = _states[key]; // Retrieves the state associated with the key
                if (value != null && value.GetType() == typeof(T)) // Checks if the value is of the expected type
                {
                    return (T)value; // Returns the state cast to the specified type
                }
            }
            return default; // Returns the default value for the specified type if the key does not exist or the value is not of the expected type
        }

        // Method to clear a state
        public void ClearState(string key)
        {
            if (_states.ContainsKey(key)) // Checks if the key exists in the dictionary
            {
                _states.Remove(key); // Removes the state associated with the specified key
            }
        }
    }
}
