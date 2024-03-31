using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        const string QueryGetAllRooms = $"SELECT {ColumnRoomNumber}, {ColumnBuildingNumber}, {ColumnFloor}, {ColumnNumberOfBeds} FROM Rooms ORDER BY {ColumnRoomNumber};";

        const string ColumnRoomNumber = "room_number";
        const string ColumnBuildingNumber = "building_number";
        const string ColumnFloor = "floor";
        const string ColumnNumberOfBeds = "number_of_beds";

        public List<Room> GetAllRooms()
        {
            SqlParameter[] sqlParameters = new SqlParameter[Zero];
            DataTable dataTable = ExecuteSelectQuery(QueryGetAllRooms, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        private Room ReadRow(DataRow dr)
        {
            string number = (string)dr[ColumnRoomNumber];
            char buildingNumber = dr[ColumnBuildingNumber].ToString()[Zero];
            int floor = (int)dr[ColumnFloor];
            int capacity = (int)dr[ColumnNumberOfBeds];

            return new Room(number, buildingNumber, floor, capacity);
        }
    }
}