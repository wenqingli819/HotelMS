using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Exceptions;
using Core.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RoomTypeRepo : EfRepo<RoomType>, IRoomTypeRepo
    {
        public RoomTypeRepo(HotelDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<IEnumerable<RoomType>> ListAllAsync()
        {
            var roomTypes = await _dbContext.RoomTypes
                .ToListAsync();
            return roomTypes;
        }

        public virtual async Task<RoomType> GetAsync(int id)
        {
            var entity = await _dbContext.Set<RoomType>().FindAsync(id);

            if (entity == null)
            {
                throw new NotFoundException("Room Not found");
            }

            return entity;
        }

        public virtual async Task<RoomType> AddAsync(RoomType entity)
        {
            _dbContext.Set<RoomType>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<RoomType> UpdateAsync(int id, RoomType entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            int affected = await _dbContext.SaveChangesAsync();
            if (affected == 1)
            {
                return entity;
            }

            return null;
        }

        public virtual async Task<bool?> DeleteAsync(int id)
        {
            var entity = _dbContext.Set<RoomType>().Find(id);
            _dbContext.Set<RoomType>().Remove(entity);
            int affected = await _dbContext.SaveChangesAsync();
            if (affected == 1)
            {
                return true;
            }
            return false;
            
        }

    }
}
