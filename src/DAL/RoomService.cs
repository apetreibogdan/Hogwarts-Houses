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

        public void DeleteRoom(int roomId)
        {
            _repository.DeleteRoom(roomId);
        }
        public void UpdateRoom(int roomId, Room room)
        {
            _repository.UpdateRoom(roomId, room);
        }

        public void AddStudent(Student student)
        {
            _repository.AddStudent(student);
        }

        public List<Student> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }

        public void AsigneStudentToRoom(int id, string name)
        {
            _repository.AsigneStudentToRoom(id, name);
        }

        public IEnumerable<Room> GetAvaibleRooms() {
            return _repository.GetAvaibleRooms(); 
        }
        
    }
}
