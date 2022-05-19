using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class AnswerRepository : IAnswerRepository
    {
        private readonly Context _context;

        public AnswerRepository(Context context)
        {
            _context = context;
        }

        public async Task AddAnswer(AnswerModel answer)
        {
            _context.Answers.Add(answer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnswer(AnswerModel answer)
        {
           _context.Answers.Remove(answer);
            await _context.SaveChangesAsync();

        }

        public async Task<AnswerModel> GetAnswer(int answerId)
        {
            var user = await _context.Answers.FirstOrDefaultAsync(x => x.Id ==  answerId);

            return user;
            
        }

        public async Task UpdateAnswer(AnswerModel answer)
        {
            _context.Answers.Update(answer);
            await _context.SaveChangesAsync();
        }
    }
}
