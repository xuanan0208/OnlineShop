﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModels
    {
        [Required]
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool RememberMe { set; get; }
    }
}