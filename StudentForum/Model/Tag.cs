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
        [Key] public int Id { get; set; }
        public string? Name { get; set; }
        public List<Ticket>? Tickets { get; set; }
        public List<Book>? Books { get; set; }
        public List<Question> Questions { get; set; } = new();
        public List<TeacherModel> Teachers { get; set; } = new();

    }
}
