using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RoomRepo : EfRepo<Room>, IRoomRepo
    {
        public RoomRepo(HotelDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<Room>> ListAllAsync()
        {
            var rooms = await _dbContext.Rooms
                .ToListAsync();
            return rooms;
        }

        public virtual async Task<Room> GetAsync(int id)
        {
            var entity = await _dbContext.Set<Room>().FindAsync(id);
            return entity;
        }

        public virtual async Task<Room> AddAsync(Room entity)
        {
            _dbContext.Set<Room>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<Room> UpdateAsync(int id, Room entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            int affected =  await _dbContext.SaveChangesAsync();
            if (affected == 1)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }

        public virtual async Task<bool?> DeleteAsync(int id)
        {
            var entity = _dbContext.Set<Room>().Find(id);
            _dbContext.Set<Room>().Remove(entity);
            int affected = await _dbContext.SaveChangesAsync();
            if (affected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
