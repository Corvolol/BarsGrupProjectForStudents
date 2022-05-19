
global using Microsoft.EntityFrameworkCore;
global using Model;

namespace DataBase
{
    public class Context: DbContext
    {
        public DbSet<UserModel> Users { get; set; } = null!;
        public DbSet<AnswerModel> Answers { get; set; } = null!;
        public DbSet<QuestionModel> Questions { get; set; } = null!;
        public DbSet<ReviewModel> Reviews { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<TeacherModel> Teachers { get; set; } = null!;
        public DbSet<Ticket> Tickets { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;

        public Context(DbContextOptions<Context>options) :base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer("Data Source=studentforum.db");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Teachers.Add(new TeacherModel(){Name = "Oleg",Cafedra = "1" });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
