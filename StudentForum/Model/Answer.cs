using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Answer
    {
<<<<<<< Updated upstream
        [Key] public int AnswerId { get; set; }
=======
        [Key] 
        public virtual int Id { get; set; }
>>>>>>> Stashed changes

        public virtual string? Login { get; set; }

<<<<<<< Updated upstream
        public string? answer { get; set; }

        public DateTime date { get; set; }

        public Question? Question { get; set; }
        public User? User { get; set; }
=======
        public virtual string? Value { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual Question? Question { get; set; }
        public virtual UserModel? User { get; set; }
>>>>>>> Stashed changes
    }

     
}
