using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesTransaction.Model;
using SalesTransaction.Service.Service;

namespace SalesTransaction.WebAPI.Areas.Account
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController  
    {
        private ILoginService _service; 

        public AccountController(ILoginService _service)
        {
            this._service = _service; //defining depedency
        }
        
        [HttpPost]
        public IActionResult Login([FromBody] MvUserLogin login)
        {
            dynamic data = _service.GetLogin(login); //invoking login method by injecting dependency
            return (data);
        }
        [HttpGet]
        public IActionResult UserDetail(string data)
        {
            dynamic display = _service.GetDetails(data);
            return (display);
        }
    }
}
