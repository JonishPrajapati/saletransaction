using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaleTransaction.Application.Model
{
    public class MvCustomer
    {
        public int customerId { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string middleName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string gender { get; set; }
    }
}
