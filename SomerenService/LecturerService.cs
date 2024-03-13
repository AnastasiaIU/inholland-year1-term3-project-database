using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class LecturerService
    {
        private LecturerDao teacherdb;

        public LecturerService()
        {
            teacherdb = new LecturerDao();
        }

        public List<Lecturer> GetLecturers()
        {
            List<Lecturer> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }
    }
}
