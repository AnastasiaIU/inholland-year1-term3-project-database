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
            string query = "SELECT room_number, building_number, floor, number_of_beds FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Number = (string)dr["room_number"],
                    BuildingNumber = dr["building_number"].ToString()[0],
                    Floor = (int)dr["floor"],
                    Capacity = (int)dr["number_of_beds"]
                };

                rooms.Add(room);
            }

            return rooms;
        }
    }
}