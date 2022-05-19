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

        [Key] public int QuestionId { get; set; }
        public string?  Essence { get; set; }
        public string? Info { get; set; }
        public List<TagModel>? Tags { get; set; }
        public List<Answer>? Answers { get; set; }
        public User? User { get; set; }

    }
}
