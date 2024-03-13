using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {

        public List<Lecturer> GetAllTeachers()
        {
            string query = "SELECT * FROM [Lecturers]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer>lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["lecturerId"];
                int age = (int)dr["age"];
                string roomNumber = (string)dr["room_number"];
                string firstName = (string)dr["first_name"];
                string lastName = (string)dr["last_name"];
                string phoneNumber;

                if (dr["phone_number"] == DBNull.Value)
                {
                    phoneNumber = null;
                }
                else
                {
                    phoneNumber = (string)dr["phone_number"];
                }
                Lecturer teacher = new Lecturer(id, age, roomNumber, firstName, lastName, phoneNumber);
                lecturers.Add(teacher);
            };
            return lecturers;
        }
    }
}
