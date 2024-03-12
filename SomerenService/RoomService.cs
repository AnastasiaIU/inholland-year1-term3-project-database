using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomdao;

        public RoomService()
        {
            roomdao = new RoomDao();
        }

        public List<Room> GetRooms()
        {
            List<Room> rooms = roomdao.GetAllRooms();
            return rooms;
        }
    }
}