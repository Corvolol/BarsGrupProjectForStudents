using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Review
    {
<<<<<<< Updated upstream:StudentForum/Model/Review.cs
        [Key] public int Id { get; set; }

        public string? review { get; set; }

        public DateTime date { get; set; }

        public Teacher? Teacher { get; set; }
        public User? User { get; set; }
=======
        [Key]
        public virtual int Id { get; set; }
        public virtual  string? Value { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual TeacherModel? Teacher { get; set; }
        public virtual UserModel? User { get; set; }
>>>>>>> Stashed changes:StudentForum/Model/ReviewModel.cs
    }
}
