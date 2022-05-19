using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class UserRepository : IUserRepository
    {
        private Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }

        public async Task AddUSer(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUser(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            return user;
        }

        public async Task UpdateUser(User updateUser)
        {
            _context.Users.Update(updateUser);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(string email, Question question)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user.Questions == null)
            {
                user.Questions = new List<Question>();
            }
            user.Questions.Add(question);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(string email, Answer answer)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user.Answers == null)
            {
                user.Answers = new List<Answer>();
            }
            user.Answers.Add(answer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(string email, ReviewModel review)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user.Reviews == null)
            {
                user.Reviews = new List<ReviewModel>();
            }
            user.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }
    }
}
