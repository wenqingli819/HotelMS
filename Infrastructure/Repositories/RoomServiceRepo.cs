using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Entities;
using Core.RepositoryInterfaces;
using Core.ServiceInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RoomServiceRepo : EfRepo<RoomService>, IRoomServiceRepo
    {
        public RoomServiceRepo(HotelDbContext dbContext) : base(dbContext)
        {
        }

        public virtual async Task<IEnumerable<RoomService>> ListAllAsync()
        {
            var services = await _dbContext.RoomServices
                .Include(rs => rs.Room)
                .ToListAsync();
            
            return services;
        }

        public virtual async Task<RoomService> GetAsync(int id)
        {
            var entity = await _dbContext.RoomServices
                .Include(rs => rs.Room)
                .FirstOrDefaultAsync();
            return entity;
        }

        public virtual async Task<RoomService> AddAsync(RoomService entity)
        {
            _dbContext.Set<RoomService>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<RoomService> UpdateAsync(int id, RoomService rc)
        {
            var dbRoomService = _dbContext.Set<RoomService>().Find(id);
            if (dbRoomService != null)
            {
                dbRoomService.RoomId = rc.RoomId;
                dbRoomService.SDesc = rc.SDesc;
                dbRoomService.ServiceDate = rc.ServiceDate;
                dbRoomService.CheckIn = rc.CheckIn;
                dbRoomService.TotalPersons = rc.TotalPersons;
                dbRoomService.BookingDays = rc.BookingDays;
                dbRoomService.Advance = rc.Advance;
                dbRoomService.Amount = rc.Amount;

                int affected = await _dbContext.SaveChangesAsync();
                if (affected == 1)
                {
                    return dbRoomService;
                }
            }
            return null;
        }

        public virtual async Task<bool?> DeleteAsync(int id)
        {
            var entity = _dbContext.Set<RoomService>().Find(id);
            _dbContext.Set<RoomService>().Remove(entity);
            int affected = await _dbContext.SaveChangesAsync();
            if (affected == 1)
            {
                return true;
            }
            return false;
        }
    }
}
