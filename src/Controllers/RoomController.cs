using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace HogwartsHouses.Controllers
{
    [Route("api/[controller]")]

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
            return _roomService.GetAllRooms(); ;
        }

        [HttpPost]
        public void AddRoom([FromBody] Room room)
        {
            _roomService.AddRoom(room);
        }

        //api/room/{roomId}
        [HttpGet("{id}")]
        public Room GetRoomById(int id)
        {
            var result = _roomService.GetRoom(id);

            return result;
        }
    }
}
