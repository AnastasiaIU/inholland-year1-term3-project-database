using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT * FROM Students";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                string phoneNumber;
                if (dr["phone_number"] == DBNull.Value)
                {
                    phoneNumber = null;
                }
                else
                {
                    phoneNumber = (string)dr["phone_number"];
                }
                string classNumber = dr["class_number"].ToString();

                Student student = new Student(studentNumber, roomNumber, firstName, lastName, phoneNumber, classNumber);
                students.Add(student);
            }
            return students;
        }
    }
}