using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IQuestionRepresitory

    {
        public Task AddQuestion(QuestionModel question);
        public Task<List<QuestionModel>> GetAllQuestion();
        public Task UpdateQuestion(QuestionModel question);
        public Task DeleteQuestion(QuestionModel question);
        public Task<QuestionModel> GetQuestion(int questionId);
        public Task<List<Answer>> GetAnswers( int questionId);
        public Task<User> GetUser(int questionId);

    }
}
