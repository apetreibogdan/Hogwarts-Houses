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
            Console.WriteLine("White on blue.");

        }
    }
}
