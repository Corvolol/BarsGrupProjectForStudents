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
<<<<<<< Updated upstream
        [Key] public int Id { get; set; }
        public string? Value { get; set; }
        public TagModel? Tag { get; set; }
=======
        [Key]
        public virtual int Id { get; set; }
        public virtual string? Value { get; set; }
        public virtual Tag? Tag { get; set; }
>>>>>>> Stashed changes
    }
}
