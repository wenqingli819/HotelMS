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
            return await _roomTypeRepo.GetAsync(id);
        }

        public async Task DeleteRoomTypeById(int id)
        { 
            await _roomTypeRepo.DeleteAsync(id);
        }

        public async Task<RoomType> AddRoomType(RoomType roomType)
        {
            return await _roomTypeRepo.AddAsync(roomType);
        }

        public async Task<IEnumerable<RoomType>> GetAllRoomTypes()
        {
            return await _roomTypeRepo.ListAllAsync();
        }

        public async Task<RoomType> UpdateById(int id, RoomType roomType)
        {
            return await _roomTypeRepo.UpdateAsync(id, roomType);
        }
    }
}
