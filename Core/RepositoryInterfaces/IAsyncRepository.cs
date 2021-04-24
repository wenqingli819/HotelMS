using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryInterfaces
{
    public interface IAsyncRepository<T> where T:class
    {
        
        Task<IEnumerable<T>> ListAllAsync();

        Task<T> GetAsync(int id);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(int id, T entity);

        Task<bool?> DeleteAsync(int id);
    }
}
