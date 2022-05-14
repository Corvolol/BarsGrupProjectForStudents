using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Model
{
    internal interface IQuestionRepresitory

    {
        public Task AddQuestion(Question question);
        public Task<List<Question>> GetAllQuestion();
        public Task UpdateQuestion(Question question);
        public Task DeleteQuestion(Question question);
        public Task<Question> GetQuestion(int questionId);
        public Task<List<Answer>> GetAnswers( int questionId);
        public Task<User> GetUser(int questionId);

    }
}
