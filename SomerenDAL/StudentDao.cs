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