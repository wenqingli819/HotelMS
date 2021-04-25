using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;
using Core.ServiceInterfaces;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomServicesController : ControllerBase
    {
        private readonly IRoomServiceService _roomService;

        public RoomServicesController(IRoomServiceService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetRoomService")]
        public async Task<IActionResult> GetRoom(int id)
        {
            var service = await _roomService.GetRoomServiceById(id);

            if (service == null)
            {
                return NotFound();
            }
            return Ok(service);
        }

        [HttpGet]
        [Route("", Name = "GetRoomServices")]
        public async Task<IActionResult> GetRoomServices()
        {
            var services = await _roomService.GetAllRoomServices();
            return Ok(services);
        }

        [HttpPost]
        [Route("", Name = "PostRoomService")]
        public async Task<IActionResult> CreateRoomService(RequestServiceAddModel roomService)
        {
            var createdRoomService = await _roomService.AddRoomService(roomService);
            return Ok(createdRoomService);
        }



        [HttpDelete]
        [Route("{id:int}", Name = "DeleteRoomService")]
        public async Task<IActionResult> DeleteRoomService(int id)
        {
            await _roomService.DeleteRoomServiceById(id);
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}", Name = "UpdateRoomService")]
        public async Task<IActionResult> UpdateRoomService(int id, RequestServiceAddModel roomService)
        {
            var updatedRoomService = await _roomService.UpdateById(id, roomService);
            return Ok(updatedRoomService);
        }
    }
}
