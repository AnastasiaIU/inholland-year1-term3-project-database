using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDao lecturerDao = new LecturerDao();

        public List<Lecturer> GetAllLecturers()
        {
            return lecturerDao.GetAllLecturers();
        }
    }
}
