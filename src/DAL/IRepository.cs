using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRepository<T>
    {
        public HashSet<Room> GetAllRooms();
        public void AddRoom(T room);
        public Room GetRoom(int id);
        void DeleteRoom(int roomId);
        void UpdateRoom(int roomId, Room room);
        void AddStudent(Student student);
        public List<Student> GetAllStudents();
        void AsigneStudentToRoom(int id, string name);
        IEnumerable<Room> GetAvaibleRooms();
    }
}
