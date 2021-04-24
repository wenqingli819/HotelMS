﻿using System;
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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public async Task DeleteCustomerById(int id)
        {
            await _customerRepo.DeleteAsync(id);
        }

        public async Task<Customer> GetCustomerDetailById(int id)
        {
            var customer = await _customerRepo.GetAsync(id);
            return customer;
        }

        public async Task<Customer> UpdateById(int id, RequestCustomerUpdateModel requestModel)
        {
            var dbCustomer = new Customer
            {
                CName = requestModel.CName,
                Email = requestModel.Email,
                Address = requestModel.Address,
                Phone = requestModel.Phone
            };
            var updatedCustomer = await _customerRepo.UpdateAsync(id,dbCustomer);
            return updatedCustomer;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            var customers = await _customerRepo.ListAllAsync();
            return customers;
        }

        public async Task<Customer> AddCustomer(RequestCustomerUpdateModel requestModel)
        {
            var dbCustomer = new Customer
            {
                CName = requestModel.CName,
                Email = requestModel.Email,
                Address = requestModel.Address,
                Phone = requestModel.Phone
            };

            var createdCustomer = await _customerRepo.AddAsync(dbCustomer);
            return createdCustomer;
        }
    }
}