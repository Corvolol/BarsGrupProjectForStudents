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
        [Key] public int TeacherId { get; set; }

        public string? name { get; set; }

        public string? cafedra { get; set; }

        public string? lesson { get; set; }

        public List<Review>? Reviews { get; set; }
        public List<TagModel>? Tags { get; set; }
    }

}
