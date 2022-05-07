using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context>options) :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
