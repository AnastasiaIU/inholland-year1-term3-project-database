using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDao lecturerdb;

        public LecturerService()
        {
            lecturerdb = new LecturerDao();
        }

        public List<Lecturer> GetLecturers()
        {            
            return lecturerdb.GetAllLecturers();
        }
    }
}
