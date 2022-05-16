﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBase
{
    public class QuestionRepresitory : IQuestionRepresitory

    {
        private readonly Context _context;

        public QuestionRepresitory(Context context)
        {
            _context = context;
        }

        public async Task AddQuestion(QuestionModel question)
        {
            _context?.Questions.Add(question);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteQuestion(QuestionModel question)
        {
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
        }

        public async Task<List<QuestionModel>> GetAllQuestion()
        {
            var questions = await _context.Questions.ToListAsync();
            return questions;
        }


        public async Task UpdateQuestion(QuestionModel question)
        {
            _context.Questions.Update(question);
            await _context.SaveChangesAsync();
        }
        public async Task<QuestionModel> GetQuestion(int questionId)
        {
            var quest = await _context.Questions.FirstOrDefaultAsync(x => x.Id == questionId);
            return quest;
        }

        public async Task<List<Answer>> GetAnswers(int questionId)
        {
            var quest = await _context.Questions.FirstOrDefaultAsync(x => x.Id == questionId);
            var answer_quest = quest.Answers;
            return answer_quest;

        }

        public async Task<UserModel> GetUser(int questionId)
        {
            var quest = await _context.Questions.FirstOrDefaultAsync(x => x.Id == questionId);
            var user = quest.User;
            return user;
        }
    }
}
