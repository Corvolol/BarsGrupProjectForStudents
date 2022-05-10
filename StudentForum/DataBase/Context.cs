﻿global using Microsoft.EntityFrameworkCore;
global using Model;

namespace DataBase
{
    public class Context: DbContext
    {
        public  DbSet<User> Users { get; set; } = null!;
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public Context(DbContextOptions<Context>options) :base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=studentforum.db");
        }
    }
}
