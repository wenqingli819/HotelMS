using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Services;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypesController : ControllerBase
    {
        private readonly RoomTypeService _roomTypeService;

        public RoomTypesController(RoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetRoomType")]
        public async Task<IActionResult> GetRoomType(int id)
        {
            var roomType = await _roomTypeService.GetRoomTypeById(id);

            if (roomType == null)
            {
                return NotFound();
            }
            return Ok(roomType);
        }

        [HttpGet]
        [Route("", Name = "GetRoomTypes")]
        public async Task<IActionResult> GetRoomTypes()
        {
            var roomTypes = await _roomTypeService.GetAllRoomTypes();
            return Ok(roomTypes);
        }

        [HttpPost]
        [Route("", Name = "PostRoomType")]
        public async Task<IActionResult> CreateRoomType(RoomType roomType)
        {
            var createdRoomType= await _roomTypeService.AddRoomType(roomType);
            return Ok(createdRoomType);
        }


        [HttpDelete]
        [Route("{id:int}", Name = "DeleteRoomType")]
        public async Task<IActionResult> DeleteRoomType(int id)
        {
            await _roomTypeService.DeleteRoomTypeById(id);
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}", Name = "UpdateRoomType")]
        public async Task<IActionResult> UpdateRoomType(int id, RoomType roomType)
        {
            var updatedRoomType = await _roomTypeService.UpdateById(id, roomType);
            return Ok(updatedRoomType);
        }

    }
}
