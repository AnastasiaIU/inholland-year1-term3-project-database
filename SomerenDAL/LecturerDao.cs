using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        const string QueryGetAllLecturers = $"SELECT {ColumnLecturerId}, {ColumnAge}, {ColumnRoomNumber}, {ColumnFirstName}, {ColumnLastName}, {ColumnPhoneNumber} FROM Lecturers ORDER BY {ColumnLastName};";

        protected const string ColumnLecturerId = "lecturerId";
        protected const string ColumnAge = "age";
        protected const string ColumnRoomNumber = "room_number";
        protected const string ColumnFirstName = "first_name";
        protected const string ColumnLastName = "last_name";
        protected const string ColumnPhoneNumber = "phone_number";

        public List<Lecturer> GetAllLecturers()
        {
            SqlParameter[] sqlParameters = new SqlParameter[Zero];
            DataTable dataTable = ExecuteSelectQuery(QueryGetAllLecturers, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        protected Lecturer ReadRow(DataRow dr)
        {
            int id = (int)dr[ColumnLecturerId];
            int age = (int)dr[ColumnAge];
            string roomNumber = (string)dr[ColumnRoomNumber];
            string firstName = (string)dr[ColumnFirstName];
            string lastName = (string)dr[ColumnLastName];
            string phoneNumber = dr[ColumnPhoneNumber] == DBNull.Value ? null : (string)dr[ColumnPhoneNumber];

            return new Lecturer(id, age, roomNumber, firstName, lastName, phoneNumber);
        }
    }
}
