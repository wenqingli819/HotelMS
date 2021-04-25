using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Exceptions;
using Core.Models;
using Core.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CustomerRepo : EfRepo<Customer>, ICustomerRepo
    {
        public CustomerRepo(HotelDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<Customer> GetAsync(int id)
        {
            var customer = await _dbContext.Customers
                .Where(c => c.Id == id)
                .Include(c => c.Services)
                .ThenInclude(rs=>rs.Room)
                .FirstOrDefaultAsync();

            if (customer == null)
            {
                throw new NotFoundException("Customer Not found");
            }

            return customer;
        }

        public override async Task<IEnumerable<Customer>> ListAllAsync()
        {
            var customers = await _dbContext.Customers
                .Include(c=>c.Services)
                .ThenInclude(rc=>rc.Room)
                .ToListAsync();
            return customers;
        }

        public override async Task<Customer> AddAsync(Customer c)
        {

            _dbContext.Set<Customer>().Add(c);
            await _dbContext.SaveChangesAsync();
            return c;
        }

        public override async Task<bool?> DeleteAsync(int id)
        {
            var customer = _dbContext.Set<Customer>().Find(id);

            if (customer != null)
            {
                _dbContext.Set<Customer>().Remove(customer);
                int affected = await _dbContext.SaveChangesAsync();
                if (affected == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<Customer> GetCustomerByEmail(string email)
        {
            return await _dbContext.Customers.FirstOrDefaultAsync(u => u.Email == email);
        }

        
        public override async Task<Customer> UpdateAsync(int id, Customer c)
        {
            var customer = _dbContext.Set<Customer>().Find(id);
            if (customer != null)
            {
                customer.CName = c.CName;
                customer.Email = c.Email;
                customer.Address = c.Address;
                customer.Phone = c.Phone;
                int affected = await _dbContext.SaveChangesAsync();
                if (affected == 1)
                {
                    return customer;
                }
            }

            return null;
        }


    }
}
