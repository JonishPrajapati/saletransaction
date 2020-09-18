﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SaleTransaction.Application.Model
{
    public class MvUserLogin
    {
        [Required]
        public int userId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int InsertPersonId { get; set; }
        public String InsertDate { get; set; }
    }
}
