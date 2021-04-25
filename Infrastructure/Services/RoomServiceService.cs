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
    public class RoomServiceService : IRoomService
    {

        private readonly IRoomRepo _roomRepo;

        public RoomServiceService(IRoomRepo roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public async Task<Room> AddRoom(Room room)
        {
            return await _roomRepo.AddAsync(room);
        }

        public async Task DeleteRoomById(int id)
        { 
            await _roomRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            var rooms = await _roomRepo.ListAllAsync();
            return rooms;
        }

        public async Task<Room> GetRoomById(int id)
        {
            return await _roomRepo.GetAsync(id);
        }


        public async Task<Room> UpdateById(int id, Room room)
        {
            return await _roomRepo.UpdateAsync(id, room);
        }
    }
}
