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
        [Key] public int Id { get; set; }

        public string? Login { get; set; }

        public string? Value { get; set; }

        public DateTime Date { get; set; }

        public Question? Question { get; set; }
        public UserModel? User { get; set; }
    }

     
}
