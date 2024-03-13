using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System.Drawing;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT * FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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