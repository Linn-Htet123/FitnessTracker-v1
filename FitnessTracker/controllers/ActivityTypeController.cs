using FitnessTracker.enums;
using FitnessTracker.models;
using static FitnessTracker.services.ActivityTypeService;
namespace FitnessTracker.controllers
{
    internal class ActivityTypeController
    {
        public ActivityType GetActivityType(ActivityTypesEnum activityName)
        {
            return GetActivityTypeByName(activityName);
        }
    }
}
