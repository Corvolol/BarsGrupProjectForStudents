﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Auth
    {
        public string? Email{ get; set; }
        public string? Password { get; set; }
    }
}
