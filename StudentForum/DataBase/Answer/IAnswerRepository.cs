using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IAnswerRepository
    {

        public Task AddAnswer(AnswerModel answer); 
        public Task UpdateAnswer(AnswerModel answer);
        public Task DeleteAnswer(AnswerModel answer);
        public Task<AnswerModel> GetAnswer(int answerId);
    }
}
