using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        public List<Lecturer> GetAllLecturers()
        {
            string query = "SELECT [lecturerId], [age], [room_number], [first_name], [last_name], [phone_number] FROM Lecturers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable);
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["lecturerId"];
                int age = (int)dr["age"];
                string roomNumber = (string)dr["room_number"];
                string firstName = (string)dr["first_name"];
                string lastName = (string)dr["last_name"];
                string phoneNumber = dr["phone_number"] == DBNull.Value ? null : (string)dr["phone_number"];

                Lecturer lecturer = new Lecturer(id, age, roomNumber, firstName, lastName, phoneNumber);
                lecturers.Add(lecturer);
            };

            return lecturers;
        }
    }
}
