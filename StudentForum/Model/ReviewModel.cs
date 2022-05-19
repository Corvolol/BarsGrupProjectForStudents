using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ReviewModel
    {
        [Key] public int Id { get; set; }
        public string? Value { get; set; }
        public DateTime Date { get; set; }
        public virtual TeacherModel? Teacher { get; set; }
        public virtual UserModel? User { get; set; }
    }
}
