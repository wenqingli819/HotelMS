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
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepo _roomTypeRepo;

        public RoomTypeService(IRoomTypeRepo roomTypeRepo)
        {
            _roomTypeRepo = roomTypeRepo;
        }

        public async Task<RoomType> GetRoomTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRoomTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomType> AddRoomType(RoomType roomType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomType>> GetAllRoomTypes()
        {
            throw new NotImplementedException();
        }

        public async Task<RoomType> UpdateById(int id, RoomType roomType)
        {
            throw new NotImplementedException();
        }
    }
}
