using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.RepositoryInterfaces;
using Core.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class RoomServiceService : IRoomServiceService
    {

        private readonly IRoomServiceRepo _roomServiceRepo;

        public RoomServiceService(IRoomServiceRepo roomServiceRepo)
        {
            _roomServiceRepo = roomServiceRepo;
        }


        public async Task<Core.Entities.RoomService> GetRoomServiceById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRoomServiceById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Core.Entities.RoomService> AddRoomService(Core.Entities.RoomService roomService)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomType>> GetAllRoomServices()
        {
            throw new NotImplementedException();
        }

        public async Task<Core.Entities.RoomService> UpdateById(int id, Core.Entities.RoomService roomService)
        {
            throw new NotImplementedException();
        }
    }
}
