using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Question
    {
<<<<<<< Updated upstream
        [Key] public int QuestionId { get; set; }
        public string?  Essence { get; set; }
        public string? Info { get; set; }
        public List<TagModel>? Tags { get; set; }
        public List<Answer>? Answers { get; set; }
        public User? User { get; set; }
=======
        [Key] 
        public virtual int Id { get; set; }
        public virtual  string?  Essence { get; set; }
        public virtual string? Info { get; set; }
        public virtual List<Tag> Tags { get; set; } = new();
        public virtual  List<Answer> Answers { get; set; } = new();
        public virtual UserModel User { get; set; } = new();
>>>>>>> Stashed changes
    }
}
