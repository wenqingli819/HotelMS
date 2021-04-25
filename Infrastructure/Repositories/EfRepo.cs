using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class EfRepo<T>:IAsyncRepository<T> where T:class
    {
        protected readonly HotelDbContext _dbContext;

        public EfRepo(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            return entity;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);    
            await _dbContext.SaveChangesAsync(); 
            return entity;
        }

        public virtual async Task<T> UpdateAsync(int id, T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified; 
            await _dbContext.SaveChangesAsync(); 
            return entity;
        }

        public virtual async Task<bool?> DeleteAsync(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            _dbContext.Set<T>().Remove(entity);
            int affected =  await _dbContext.SaveChangesAsync();
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
