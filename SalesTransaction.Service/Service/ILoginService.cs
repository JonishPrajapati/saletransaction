using System;
using System.Collections.Generic;
using System.Text;
using SalesTransaction.Model;
namespace SalesTransaction.Service.Service
{
    public interface ILoginService
    {
        public dynamic GetLogin(MvUserLogin userLogin);
        public dynamic GetDetails(String data);
    }
}

