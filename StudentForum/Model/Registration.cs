using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class Registration
    {
       [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string LastName{ get; set; }

        public string login { get; set; }
        
        public int Groupnumber { get; set; }

        public string fakultat { get; set; }

        public string spez { get; set; }

        public string email { get; set; }

        public string password { get; set; }
    }
}
