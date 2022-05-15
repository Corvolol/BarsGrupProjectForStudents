using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Teacher
    {
        [Key] public int Id { get; set; }
        public string? Name { get; set; }
        public string? Cafedra { get; set; }
        public string? Lesson { get; set; }
        public List<ReviewModel> Reviews { get; set; } = new();
        public List<Tag>? Tags { get; set; } = new();
    }

}
