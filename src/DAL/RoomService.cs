using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }
        public HashSet<Room> GetAllRooms()=>_repository.GetAllRooms();

        public void AddRoom(Room room)
        {
            _repository.AddRoom(room);
        }

        public Room GetRoom(int roomId)
        {
            return _repository.GetRoom(roomId);
        }
    }
}
