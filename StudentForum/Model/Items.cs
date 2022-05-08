using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Items
    {
        [Key] public int Id { get; set; }

        public string name { get; set; }

        public string tickets { get; set; }

        public string books { get; set; }

        public string test { get; set; }
    }

}
