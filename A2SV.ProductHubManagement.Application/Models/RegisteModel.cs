﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2SV.ProductHubManagement.Application.Models
{
    public class RegisteModel
    {
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(10)]
        public string Password { get; set; }

        public string FullName { get; set; }
    }
}