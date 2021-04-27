using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;
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
            return await _roomServiceRepo.GetAsync(id);
        }

        public async Task DeleteRoomServiceById(int id)
        { 
            await _roomServiceRepo.DeleteAsync(id);
        }

        public async Task<Core.Entities.RoomService> AddRoomService(RequestServiceAddModel roomService)
        {
            var dbService = new Core.Entities.RoomService()
            {
                RoomId = roomService.RoomId,
                CustomerId = roomService.CustomerId,
                SDesc = roomService.SDesc,
                ServiceDate = roomService.ServiceDate,
                CheckIn = roomService.CheckIn,
                TotalPersons = roomService.TotalPersons,
                BookingDays = roomService.BookingDays,
                Advance = roomService.Advance,
                Amount = roomService.Amount
            };

            return await _roomServiceRepo.AddAsync(dbService);
        }

        public async Task<IEnumerable<Core.Entities.RoomService>> GetAllRoomServices()
        {
            return await _roomServiceRepo.ListAllAsync();
        }

        public async Task<Core.Entities.RoomService> UpdateById(int id, RequestServiceAddModel roomService)
        {
            // convert RequestServiceAddModel -> RoomService
            var dbService = new Core.Entities.RoomService()
            {
                RoomId = roomService.RoomId,
                CustomerId = roomService.CustomerId,
                SDesc = roomService.SDesc,
                ServiceDate = roomService.ServiceDate,
                CheckIn = roomService.CheckIn,
                TotalPersons = roomService.TotalPersons,
                BookingDays = roomService.BookingDays,
                Advance = roomService.Advance,
                Amount = roomService.Amount
            };
            return await _roomServiceRepo.UpdateAsync(id, dbService);
        }
    }
}
