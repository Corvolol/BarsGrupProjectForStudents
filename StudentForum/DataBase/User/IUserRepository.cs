using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public interface IUserRepository
    {
        public Task AddUSer(UserModel user);
        public Task<UserModel> GetUser(string email);
        public Task UpdateUser (UserModel user);
        public Task DeleteUser (string email);
    }
}
