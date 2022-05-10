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
        public string? name { get; set; }
        public List<string>? tickets { get; set; }
        public List<string>? books { get; set; }
        public List<Question>? Questions { get; set; }
        public List<Teacher>? Teachers { get; set; }

    }
}
