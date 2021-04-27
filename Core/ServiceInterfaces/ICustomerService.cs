using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Models;

namespace Core.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<Customer> GetCustomerDetailById(int id);
        Task DeleteCustomerById(int id);
        Task<Customer> AddCustomer(RequestCustomerUpdateModel c);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> UpdateById(int id, RequestCustomerUpdateNoEmail c);

        Task<bool> CustomerExist(RequestCustomerUpdateModel customer);

    }
}
