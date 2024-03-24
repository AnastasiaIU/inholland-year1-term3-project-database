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
            return ReadTables(dataTable);
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string number = (string)dr["room_number"];
                char buildingNumber = dr["building_number"].ToString()[0];
                int floor = (int)dr["floor"];
                int capacity = (int)dr["number_of_beds"];

                Room room = new Room(number, buildingNumber, floor, capacity);
                rooms.Add(room);
            }

            return rooms;
        }
    }
}