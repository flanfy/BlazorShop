﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Shared
{
    public class UserChangePassword
    {
        [Required, StringLength(25, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "Password does not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}