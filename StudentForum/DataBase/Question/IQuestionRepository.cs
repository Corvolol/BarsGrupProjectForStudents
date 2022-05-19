using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IQuestionRepository

    {
        public Task AddQuestion(QuestionModel question);
        public Task<List<QuestionModel>> GetAllQuestion();
        public Task UpdateQuestion(QuestionModel question);
        public Task DeleteQuestion(QuestionModel question);
        public Task<QuestionModel> GetQuestion(int questionId);
        public Task<List<AnswerModel>> GetAnswers( int questionId);
        public Task<UserModel> GetUser(int questionId);

    }
}
