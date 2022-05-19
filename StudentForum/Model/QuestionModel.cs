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
        [Key] public int Id { get; set; }
        public string? Essence { get; set; }
        public string? Info { get; set; }
        public List<TagModel> Tags { get; set; } = new();
        public List<AnswerModel> Answers { get; set; } = new();
        public virtual UserModel User { get; set; } = new();
    }
}

