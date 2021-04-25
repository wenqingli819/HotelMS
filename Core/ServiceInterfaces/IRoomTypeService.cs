using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.ServiceInterfaces
{
    public interface IRoomTypeService
    {
        Task<RoomType> GetRoomTypeById(int id);
        Task DeleteRoomTypeById(int id);
        Task<RoomType> AddRoomType(RoomType roomType);
        Task<IEnumerable<RoomType>> GetAllRoomTypes();
        Task<RoomType> UpdateById(int id, RoomType roomType);
    }
}
