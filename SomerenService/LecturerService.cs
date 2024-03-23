using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDao lecturerDao;

        public LecturerService()
        {
            lecturerDao = new LecturerDao();
        }

        public List<Lecturer> GetLecturers()
        {
            return lecturerDao.GetAllLecturers();
        }
    }
}
