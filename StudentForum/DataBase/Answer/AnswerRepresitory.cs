using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class AnswerRepresitory : IAnswerRepresitory
    {
        private readonly Context _context;

        public AnswerRepresitory(Context context)
        {
            _context = context;
        }

        public async Task AddAnswer(Answer answer)
        {
            _context.Answers.Add(answer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnswer(Answer answer)
        {
           _context.Answers.Remove(answer);
            await _context.SaveChangesAsync();

        }

        public async Task<Answer> GetUserOfAnswer(int answerId)
        {
            var user = await _context.Answers.FirstOrDefaultAsync(x => x.Id ==  answerId);

            return user;
            
        }

        public async Task UpdateAnswer(Answer answer)
        {
            _context.Answers.Update(answer);
            await _context.SaveChangesAsync();
        }
    }
}
