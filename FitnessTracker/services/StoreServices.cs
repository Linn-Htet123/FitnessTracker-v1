using FitnessTracker.helpers;

namespace FitnessTracker.services
{
    internal static class StoreServices
    {
        public static void SetState<T>(T data, string key)
        {
            ApplicationStore.Instance.SetState(key, data);
        }

        public static T GetState<T>(string key)
        {
            return ApplicationStore.Instance.GetState<T>(key);
        }

        public static void ClearState(string key)
        {
            ApplicationStore.Instance.ClearState(key);
        }
    }
}
