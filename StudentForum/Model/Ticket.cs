using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Ticket
    {

        [Key] 
        public virtual int Id { get; set; }
        public virtual  string? Value { get; set; }
        public virtual TagModel? Tag { get; set; }

       

    }
}
