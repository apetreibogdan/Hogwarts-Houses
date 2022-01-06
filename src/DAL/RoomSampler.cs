using System;
using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.DAL
{
    public class RoomSampler
    {
        public HashSet<Room> Rooms = new HashSet<Room>();
        public List<Student> Students = new List<Student>();
        public RoomSampler()
        {
            Initialize();
        }

        public void Initialize()
        {
            Student bobo1 = new Student( "bobo11", PetType.Cat);
            Student bobo2 = new Student( "bobo22", PetType.Owl);
            Student bobo3 = new Student( "bobo33", PetType.Rat);

            Students.Add(bobo1);
            Students.Add(bobo2);    
            Students.Add(bobo3);

            List<Student> room1Students = new List<Student>(){ bobo1, bobo2};
            List<Student> room2Students = new List<Student>() { bobo2, bobo3 };

            Room room1 = new Room(1, true, room1Students);
            Room room2 = new Room(2,true, room2Students);
          //  Room room2 = new Room(1,true,Students); 
          //  Room room3 = new Room(1,true);
            Rooms.Add(room1);
            Rooms.Add(room2);
           
          //  Rooms.Add(room2);
          //  Rooms.Add(room3);
        }
    }
}
