using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;
using Core.ServiceInterfaces;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetRoom")]
        public async Task<IActionResult> GetRoom(int id)
        {
            var room = await _roomService.GetRoomById(id);
            return Ok(room);
        }

        [HttpGet]
        [Route("", Name = "GetRooms")]
        public async Task<IActionResult> GetRooms()
        {
            var rooms = await _roomService.GetAllRooms();
            return Ok(rooms);
        }

        [HttpPost]
        [Route("", Name = "PostRoom")]
        public async Task<IActionResult> CreateRoom(Room room)
        {
            var createdRoom = await _roomService.AddRoom(room);
            return Ok(createdRoom);
        }



        [HttpDelete]
        [Route("{id:int}", Name = "DeleteRoom")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.DeleteRoomById(id);
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}", Name = "UpdateRoom")]
        public async Task<IActionResult> UpdateRoom(int id, Room room)
        {
            var updatedRoom = await _roomService.UpdateById(id, room);
            return Ok(updatedRoom);
        }
    }
}
