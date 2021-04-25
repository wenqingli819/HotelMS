using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;

namespace Core.ServiceInterfaces
{
    public interface IRoomServiceService
    {
        Task<RoomService> GetRoomServiceById(int id);
        Task DeleteRoomServiceById(int id);
        Task<RoomService> AddRoomService(RequestServiceAddModel roomService);
        Task<IEnumerable<RoomService>> GetAllRoomServices();
        Task<RoomService> UpdateById(int id, RequestServiceAddModel roomService);
    }
}
