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
            Student bobo1 = new Student(1, "bobo11", PetType.Cat);
            Student bobo2 = new Student(2, "bobo22", PetType.Owl);
            Student bobo3 = new Student(3, "bobo33", PetType.Rat);


            Students.Add(bobo1);
            Students.Add(bobo2);
            Students.Add(bobo3);

            Room room1 = new Room(1,true,Students); 
            Room room2 = new Room(2,true,Students);
          //  Room room2 = new Room(1,true,Students); 
          //  Room room3 = new Room(1,true);
            Rooms.Add(room1);
            Rooms.Add(room2);
           
          //  Rooms.Add(room2);
          //  Rooms.Add(room3);
        }
    }
}
