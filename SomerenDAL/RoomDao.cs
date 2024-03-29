using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT [room_number], [building_number], [floor], [number_of_beds] FROM Rooms ORDER BY [room_number]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        private Room ReadRow(DataRow dr)
        {
            string number = (string)dr["room_number"];
            char buildingNumber = dr["building_number"].ToString()[0];
            int floor = (int)dr["floor"];
            int capacity = (int)dr["number_of_beds"];

            return new Room(number, buildingNumber, floor, capacity);
        }
    }
}