using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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

    }
}
