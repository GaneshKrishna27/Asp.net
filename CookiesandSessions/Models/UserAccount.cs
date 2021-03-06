﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookiesandSessions.Models
{
    public class UserAccount
    {
        [Key]
        public string Username { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
    }
}
