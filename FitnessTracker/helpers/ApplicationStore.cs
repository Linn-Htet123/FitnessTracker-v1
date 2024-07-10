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
            _states = new Dictionary<string, object>();
        }

        public static ApplicationStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApplicationStore();
                }
                return _instance;
            }
        }

        // Method to set or update a state
        public void SetState(string key, object state)
        {
            _states[key] = state;
        }

        // Method to get a state
        public T GetState<T>(string key)
        {
            if (_states.ContainsKey(key))
            {
                object value = _states[key];
                if (value != null && value.GetType() == typeof(T))
                {
                    return (T)value;
                }
            }
            return default;
        }


        // Method to clear a state
        public void ClearState(string key)
        {
            if (_states.ContainsKey(key))
            {
                _states.Remove(key);
            }
        }
    }
}
