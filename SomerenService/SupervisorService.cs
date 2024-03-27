using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class SupervisorService
    {
        private SupervisorDao supervisorDao;

        public SupervisorService()
        {
            supervisorDao = new SupervisorDao();
        }

        public List<Lecturer> GetAllSupervisorsForActivity(Activity activity)
        {
            return supervisorDao.GetAllSupervisorsForActivity(activity);
        }

        public List<Lecturer> GetAllAvailableSupervisorsForActivity(Activity activity)
        {
            return supervisorDao.GetAllAvailableSupervisorsForActivity(activity);
        }

        public void AddSupervisorToActivity(Lecturer lecturer, Activity activity)
        {
            supervisorDao.AddSupervisorToActivity(lecturer, activity);
        }

        public void DeleteSupervisorForActivity(Lecturer lecturer, Activity activity)
        {
            supervisorDao.DeleteSupervisorForActivity(lecturer, activity);
        }
    }
}
