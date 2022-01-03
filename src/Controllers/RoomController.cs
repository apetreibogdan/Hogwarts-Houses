using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HogwartsHouses.Controllers
{
    [Route("/")]
    [ApiController]
    public class RoomController : ControllerBase
    {
     private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

     [HttpGet]
        public HashSet<Room> Index()
        {
            var roomsList = _roomService.GetAllRooms();
            return roomsList;
            
        }
    }
}
