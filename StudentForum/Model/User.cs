using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    internal class User
    {
        [Key] public int Id { get; set; }
        public string login{ get; set; }
        public string password { get; set; }
    }
}
