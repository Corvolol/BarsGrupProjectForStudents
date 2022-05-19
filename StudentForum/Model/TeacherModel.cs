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
        public virtual  int Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Cafedra { get; set; }
        public virtual  List<ReviewModel> Reviews { get; set; } = new();
        public virtual  List<Tag>? Tags { get; set; } = new();
    }

}
