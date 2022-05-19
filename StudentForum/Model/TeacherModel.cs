using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class TeacherModel
    {
        [Key] 
        public  int Id { get; set; }
        public  string? Name { get; set; }
        public  string? Cafedra { get; set; }
        public   List<ReviewModel> Reviews { get; set; } = new();
        public  List<TagModel>? Tags { get; set; } = new();
    }

}
