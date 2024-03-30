using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomDao = new RoomDao();

        public List<Room> GetAllRooms()
        {
            return roomDao.GetAllRooms();
        }
    }
}