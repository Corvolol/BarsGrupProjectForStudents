using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Tag
    {
        [Key] 
        public virtual int Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual List<Ticket>? Tickets { get; set; }
        public virtual List<Book>? Books { get; set; } = new();
        public virtual List<Question> Questions { get; set; } = new();
        public virtual List<TeacherModel> Teachers { get; set; } = new();

    }
}
