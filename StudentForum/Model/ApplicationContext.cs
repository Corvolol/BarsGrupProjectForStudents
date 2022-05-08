using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Microsoft.EntityFrameworkCore;

namespace Model
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Auth> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated(); 
        }
    }
}


    
   