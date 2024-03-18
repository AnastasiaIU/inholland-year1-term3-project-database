using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activityDAO;

        public ActivityService()
        {
            activityDAO = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            return activityDAO.GetAllActivities();
        }
    }
}
