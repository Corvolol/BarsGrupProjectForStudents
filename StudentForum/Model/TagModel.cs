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
        [Key] public int TagId { get; set; }
        public string? name { get; set; }
        public List<Ticket>? Tickets { get; set; }
        public List<Book>? Books { get; set; }
        public List<Question>? Questions { get; set; }
        public List<Teacher>? Teachers { get; set; }

    }
}
