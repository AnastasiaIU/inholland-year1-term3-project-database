using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomDAO;

        public RoomService()
        {
            roomDAO = new RoomDao();
        }

        public List<Room> GetRooms()
        {            
            return roomDAO.GetAllRooms();
        }
    }
}