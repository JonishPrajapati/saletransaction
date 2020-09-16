using Microsoft.AspNetCore.Mvc;
using SalesTransaction.Service.Service;
using SalesTransaction.WebAPI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTransaction.WebAPI.Areas
{
    public class AccountController : BaseController
    {
        private ILoginService _service;
        public AccountController(ILoginService _service)
        {
            this._service = _service; //defining depedency

        }
      
        [HttpGet]
        public ActionResult UserDetail()
        {
            Console.WriteLine("userdetails");
            //dynamic display = this._service.GetDetails();
            return Ok("sdfsd");
        }

        //[HttpGet]
        //public string GetMthod()
        //{
        //    return ("service");
        //}

    }
}
