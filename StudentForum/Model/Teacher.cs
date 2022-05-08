using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Teacher
    {
        [Key] public int Id { get; set; }

        public string name { get; set; }

        public string cafedra { get; set; }

        public string lesson { get; set; }

        public string login { get; set; }
    }

}
