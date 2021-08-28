using System;
using Microsoft.EntityFrameworkCore;
using ToDoListByLexa.Models;

namespace ToDoListByLexa
{
    public class AppDbContext : DbContext
    {
        public string DbPath { get; private set; }

        public DbSet<Goals> Goals { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>optionsBuilder.UseSqlite($"Data Source=ToDoListDb.db");
    }
}
