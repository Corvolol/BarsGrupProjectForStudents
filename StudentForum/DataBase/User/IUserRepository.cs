using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IUserRepository
    {
        public Task AddUSer(User user);
        public Task<User> GetUser(string email);
        public Task<bool> UpdateUser (User user);
        public Task<bool> UpdateUser(string email,Question question);
        public Task<bool> UpdateUser(string email,Answer answer);
        public Task<bool> UpdateUser(string email,Review review);
        public Task<bool> DeleteUser (string email);
    }
}
