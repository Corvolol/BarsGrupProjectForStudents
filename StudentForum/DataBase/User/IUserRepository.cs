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
        public Task UpdateUser (User user);
        public Task UpdateUser(string email,Question question);
        public Task UpdateUser(string email,Answer answer);
        public Task UpdateUser(string email,Review review);
        public Task DeleteUser (string email);
    }
}
