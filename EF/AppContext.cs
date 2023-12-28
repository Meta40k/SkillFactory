using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace FirstApp
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Ваша строка подключения к БД");
        }
    }
}