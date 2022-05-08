using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Question
    {
        [Key] public int Id { get; set; }

        public string  Essence { get; set; }

        public string Info { get; set; }
    }
}
