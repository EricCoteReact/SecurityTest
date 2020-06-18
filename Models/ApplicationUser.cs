﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Department { get; set; }
    }
}
