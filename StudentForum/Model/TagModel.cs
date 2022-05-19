using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class TagModel
    {
        [Key] public int Id { get; set; }
        public string? Name { get; set; }
        public List<Ticket>? Tickets { get; set; }
        public List<Book>? Books { get; set; } = new();
        public List<QuestionModel> Questions { get; set; } = new();
        public List<TeacherModel> Teachers { get; set; } = new();

    }
}
