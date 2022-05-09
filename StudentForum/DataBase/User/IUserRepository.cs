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
    }
}
