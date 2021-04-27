using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Exceptions;
using Core.Models;
using Core.ServiceInterfaces;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetCustomer")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _customerService.GetCustomerDetailById(id);

            if (customer==null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet]
        [Route("", Name = "GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpPost]
        [Route("", Name = "PostCustomer")]
        public async Task<IActionResult> CreateCustomer(RequestCustomerUpdateModel customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest();
                }

                // check whether the customer already exist or not by email
                var isCustomerExist = await _customerService.CustomerExist(customer);
                if (isCustomerExist)
                {
                    ModelState.AddModelError("email", "Employee email already in use");
                    return BadRequest(ModelState);
                }

                var createdCustomer = await _customerService.AddCustomer(customer);

                return Ok(createdCustomer);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    


        [HttpDelete]
        [Route("{id:int}", Name = "DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _customerService.DeleteCustomerById(id);
            return Ok();
        }

        [HttpPut]
        [Route("{id:int}", Name = "UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer(int id, RequestCustomerUpdateModel c)
        {
            var updatedCustomer = await _customerService.UpdateById(id,c);
            return Ok(updatedCustomer);
        }
    }
}
