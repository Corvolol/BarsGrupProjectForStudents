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
        [Key] public int AnswerId { get; set; }

        public string? Login { get; set; }

        public string? answer { get; set; }

        public DateTime date { get; set; }

        public Question? Question { get; set; }
        public User? User { get; set; }
    }

     
}
