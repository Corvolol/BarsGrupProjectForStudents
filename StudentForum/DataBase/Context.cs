global using Microsoft.EntityFrameworkCore;
global using Model;

namespace DataBase
{
    public class Context: DbContext
    {
       public  DbSet<User> Users { get; set; } = null!;
        public Context(DbContextOptions<Context>options) :base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
