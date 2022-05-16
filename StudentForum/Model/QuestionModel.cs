using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class QuestionModel
    {
        [Key] public int QuestionId { get; set; }
        public string?  Essence { get; set; }
        public string? Info { get; set; }
        public List<Tag>? Tags { get; set; }
        public List<Answer>? Answers { get; set; }
        public UserModel? User { get; set; }
    }
}
