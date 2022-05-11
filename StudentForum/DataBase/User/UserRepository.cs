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
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteUser(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
            {
                return false;
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User> GetUser(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            return user;
        }

        public async Task<bool> UpdateUser(User updateUser)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == updateUser.Email);
            if (user == null)
            {
                return false;
            }
            user.Faculty = updateUser.Faculty;
            user.NickName = updateUser.NickName;
            user.Password = updateUser.Password;
            user.Groupnumber = updateUser.Groupnumber;
            return true;
        }

        public async Task<bool> UpdateUser(string email, Question question)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
            {
                return false;
            }
            user.Questions.Add(question);
            return true;
        }

        public async Task<bool> UpdateUser(string email, Answer answer)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
            {
                return false;
            }
            user.Answers.Add(answer);
            return true;
        }

        public async Task<bool> UpdateUser(string email, Review review)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
            {
                return false;
            }
            user.Reviews.Add(review);
            return true;
        }
    }
}
