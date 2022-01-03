using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRepository<T>
    {
        public HashSet<Room> GetAllRooms();
        public void AddRoom(T room);
        public Room GetRoom(int id);
    }
}
