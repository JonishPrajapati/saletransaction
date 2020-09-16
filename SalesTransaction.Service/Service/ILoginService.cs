using System;
using System.Collections.Generic;
using System.Text;
using SalesTransaction.Model;
namespace SalesTransaction.Service.Service
{
    public interface ILoginService
    {
       dynamic GetLogin(MvUserLogin userLogin);
       dynamic GetDetails();
    }
}

