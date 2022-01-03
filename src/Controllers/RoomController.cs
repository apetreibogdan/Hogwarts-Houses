using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace HogwartsHouses.Controllers
{
    [Route("/rooms")]
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

    [HttpPost]
    public void AddRoom([FromBody]Room room)
        {
            _roomService.AddRoom(room);

        }
    }
   
    
}
