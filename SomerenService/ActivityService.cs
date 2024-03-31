using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activityDao = new ActivityDao();

        public List<Activity> GetAllActivities()
        {
            return activityDao.GetAllActivities();
        }
    }
}
