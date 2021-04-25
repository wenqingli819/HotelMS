using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;

namespace Core.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<Room> GetRoomById(int id);
        Task DeleteRoomById(int id);
        Task<Room> AddRoom(Room room);
        Task<IEnumerable<Room>> GetAllRooms();
        Task<Room> UpdateById(int id, Room room);
    }
}
