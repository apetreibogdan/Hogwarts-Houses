using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRoomService
    {
        HashSet<Room> GetAllRooms();
        public void AddRoom(Room room);
        public Room GetRoom(int roomId);
        void DeleteRoom(int id);
        void UpdateRoom(int id, Room room);
        void AddStudent(Student student);
        List<Student> GetAllStudents();
    }
}
