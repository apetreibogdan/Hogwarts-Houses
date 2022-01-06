using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HogwartsHouses.DAL
{
    public class RoomSampledRepository : IRepository<Room>
    {
        private RoomSampler _roomSampler { get; }

        public RoomSampledRepository()
        {
            _roomSampler = new RoomSampler();
        }

        public HashSet<Room> GetAllRooms()
        {
            return _roomSampler.Rooms;
        }

        public void AddRoom(Room room)
        {
            _roomSampler.Rooms.Add(room);
        }

        public Room GetRoom(int roomId)
        {
            foreach (var room in _roomSampler.Rooms)
            {
                if (room.ID == roomId)
                {       
                    return room;
                }
            }
            return null;
        }

        public void DeleteRoom(int roomId)
        {
            _roomSampler.Rooms.RemoveWhere(room => room.ID == roomId);
        }

        public void UpdateRoom(int roomId, Room room )
        {
            _roomSampler.Rooms.RemoveWhere(room => room.ID == roomId);
            _roomSampler.Rooms.Add(room);
        }

        public void AddStudent(Student student)
        {
            _roomSampler.Students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return _roomSampler.Students;
        }

        public void AsigneStudentToRoom(int id, string name)
        {
            var room = GetRoom(id);
            var student = GetStudentByName(name);
            room.Students.Add(student);
        }

        public Student GetStudentByName(string name)
        {
            foreach(Student student in _roomSampler.Students)
            {
                if (student.Name == name)
                {
                    return student;
                }
            }
            return null;
        }

        public IEnumerable <Room> GetAvaibleRooms()
        {
        

            return _roomSampler.Rooms.Where(x => x.Available == true);

        }

    }
}
