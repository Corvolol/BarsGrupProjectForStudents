﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Otziv
    {
        [Key] public int Id { get; set; }

        public string otziv { get; set; }

        public DateTime date { get; set; }
    }
}
