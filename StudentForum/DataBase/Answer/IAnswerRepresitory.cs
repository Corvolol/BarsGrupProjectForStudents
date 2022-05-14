using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal interface IAnswerRepresitory
    {

        public Task AddAnswer(Answer answer); 
        public Task UpdateAnswer(Answer answer);
        public Task DeleteAnswer(Answer answer);
        public Task<Answer> GetUserOfAnswer(int answerId);
    }
}
