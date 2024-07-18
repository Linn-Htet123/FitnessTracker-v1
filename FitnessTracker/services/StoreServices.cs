using FitnessTracker.helpers;

namespace FitnessTracker.services
{
    internal static class StoreServices
    {
        // Set a state with a specific key
        public static void SetState<T>(T data, string key)
        {
            ApplicationStore.Instance.SetState(key, data);
        }

        // Get state of type T by key
        public static T GetState<T>(string key)
        {
            return ApplicationStore.Instance.GetState<T>(key);
        }

        // Clear state by key
        public static void ClearState(string key)
        {
            ApplicationStore.Instance.ClearState(key);
        }
    }
}
