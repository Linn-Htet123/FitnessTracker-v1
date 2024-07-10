using System;
using static FitnessTracker.utils.ModalPopup;
namespace FitnessTracker.helpers
{
    public static class ErrorHandling
    {
        public static void HandleError(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception error)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error occurred: {error.Message}");
                ErrorPopup($"Error occurred: {error.Message}");
                throw;
            }
        }

        public static T HandleError<T>(Func<T> func)
        {
            try
            {
                return func.Invoke();
            }
            catch (Exception error)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error occurred: {error.Message}");
                ErrorPopup($"Error occurred: {error.Message}");
                return default;
            }
        }
    }
}
