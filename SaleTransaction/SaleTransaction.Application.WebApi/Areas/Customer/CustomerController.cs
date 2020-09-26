using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleTransaction.Application.Model;
using SaleTransaction.Application.Service.Customer;
using SaleTransaction.Application.WebApi.Base;

namespace SaleTransaction.Application.WebApi.Areas.Customer
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpPost]
        public IActionResult customerAdd([FromBody] MvCustomer customer)
        {
            try
            {
                var data = _customerService.addCustomer(customer);
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        [HttpGet]
        public IActionResult GetDetail()
        {
            try
            {
                var details = _customerService.GetCustomerDetails();
                return Ok(details);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        [HttpPost]
        public IActionResult productUpdate([FromBody] MvCustomer customer)
        {
            try
            {
                var data = _customerService.updateCustomer(customer);

                return Ok(data);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
