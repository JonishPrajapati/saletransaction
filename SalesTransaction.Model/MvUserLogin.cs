using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SalesTransaction.Model
{
    public class MvUserLogin
    {
       
        public int userId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int InsertPersonId { get; set; }
        public String InsertDate { get; set; }
    }
}
