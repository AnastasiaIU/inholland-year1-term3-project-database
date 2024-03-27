using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT [student_number], [room_number], [first_name], [last_name], [phone_number], [class_number] FROM Students ORDER BY [last_name]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable);
        }

        public void CreateStudent(Student student)
        {
            string query = "INSERT INTO Students (student_number, room_number, first_name, last_name, phone_number, class_number) VALUES (@StudentNumber, @RoomNumber, @FirstName, @LastName, @PhoneNumber, @ClassNumber)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentNumber", student.StudentNumber),
                new SqlParameter("@RoomNumber", student.RoomNumber),
                new SqlParameter("@FirstName", student.FirstName),
                new SqlParameter("@LastName", student.LastName),
                new SqlParameter("@PhoneNumber", student.PhoneNumber),
                new SqlParameter("@ClassNumber", student.ClassNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateStudent(Student student)
        {
            string query = "UPDATE Students SET [first_name]=@FirstName, [last_name]=@LastName, [phone_number]=@PhoneNumber WHERE [student_number]=@StudentNumber";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName", student.FirstName),
                new SqlParameter("@LastName", student.LastName),
                new SqlParameter("@PhoneNumber", student.PhoneNumber),
                new SqlParameter("@StudentNumber", student.StudentNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteStudent(Student student)
        {
            string query = "DELETE FROM Students WHERE [student_number]=@StudentNumber";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentNumber", student.StudentNumber)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int studentNumber = (int)dr["student_number"];
                string roomNumber = dr["room_number"].ToString();
                string firstName = dr["first_name"].ToString();
                string lastName = dr["last_name"].ToString();
                string phoneNumber = dr["phone_number"] == DBNull.Value ? null : (string)dr["phone_number"];
                string classNumber = dr["class_number"].ToString();

                Student student = new Student(studentNumber, roomNumber, firstName, lastName, phoneNumber, classNumber);
                students.Add(student);
            }

            return students;
        }
    }
}