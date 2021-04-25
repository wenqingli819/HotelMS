using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.ServiceInterfaces
{
    public interface IRoomServiceService
    {
        Task<RoomService> GetRoomServiceById(int id);
        Task DeleteRoomServiceById(int id);
        Task<RoomService> AddRoomService(RoomService roomService);
        Task<IEnumerable<RoomType>> GetAllRoomServices();
        Task<RoomService> UpdateById(int id, RoomService roomService);
    }
}
