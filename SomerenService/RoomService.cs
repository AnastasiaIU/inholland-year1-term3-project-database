using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomDao;

        public RoomService()
        {
            roomDao = new RoomDao();
        }

        public List<Room> GetRooms()
        {
            return roomDao.GetAllRooms();
        }
    }
}