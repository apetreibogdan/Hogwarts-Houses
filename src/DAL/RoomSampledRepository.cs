using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;
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
        

            return _roomSampler.Rooms.Where(room => room.Available == true);

        }


        public IEnumerable<Room> GetAvaibleRoomsForRatOwner()
        {
            List<Room> roomsWithoutCatsOrOwls = new List<Room>();
            foreach (var room in _roomSampler.Rooms)
            {
                bool isRoomWithoutCatsOrOwls = true;
                foreach (var student in room.Students)
                {
                    if (student.Pet == PetType.Owl || student.Pet == PetType.Cat)
                    {
                        isRoomWithoutCatsOrOwls = false;
                    }
                }
                if (isRoomWithoutCatsOrOwls)
                {
                    roomsWithoutCatsOrOwls.Add(room);
                }
            }
            return roomsWithoutCatsOrOwls;
        }
            
                                           

  

     //       return _roomSampler.Rooms.Where(room => room.Students.Where(student => (student.Pet == Models.Types.PetType.Cat).
                                                              //    Where(student.Pet == Models.Types.PetType.Owl))
    

       

    }
}
