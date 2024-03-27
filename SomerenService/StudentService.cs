using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentDao;

        public StudentService()
        {
            studentDao = new StudentDao();
        }

        public List<Student> GetAllStudents()
        {
            return studentDao.GetAllStudents();
        }

        public void CreateStudent(Student student)
        {
            studentDao.CreateStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            studentDao.UpdateStudent(student);
        }

        public void DeleteStudent(Student student)
        {
            studentDao.DeleteStudent(student);
        }
    }
}