﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;


namespace Model
{
   
    public class User
    {
        [Key]
        public string Email { get; set; } = null!;
        
        public string NickName { get; set; }

        public string Name { get; set; }

        public string LastName{ get; set; }

        public int Groupnumber { get; set; }

        public string Faculty { get; set; }

        public string Speciality { get; set; }

        public string Password { get; set; }
    }
}
