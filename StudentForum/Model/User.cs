using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;


namespace Model
{
   
    public class User
    {
        [Key]
        public virtual  string Email { get; set; } = null!;
        
        public virtual string? NickName { get; set; }

        public virtual  string? Name { get; set; }

        public virtual  string? LastName{ get; set; }

        public virtual int? Groupnumber { get; set; }

        public virtual string? Faculty { get; set; }

        public virtual string? Speciality { get; set; }

        public virtual string? Password { get; set; }

<<<<<<< Updated upstream:StudentForum/Model/User.cs
        public List<Question>? Questions { get; set; }
        public List<Answer>? Answers { get; set; }
        public List<Review>? Reviews { get; set; }
=======
        public virtual  List<Question> Questions { get; set; } = new();
        public virtual List<Answer> Answers { get; set; } = new();
        public virtual  List<ReviewModel> Reviews { get; set; } = new();
>>>>>>> Stashed changes:StudentForum/Model/UserModel.cs
    }
}
