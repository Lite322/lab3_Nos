using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Nos.DB
{
    internal class MySqlLiteContext : DbContext
    {
        public MySqlLiteContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=SaveInfoGamer.db");
        }
        public DbSet<Model.Gamer> Gamers { get; set; }
        public DbSet<Model.Guitar> Guitars { get; set; }
        public DbSet<Model.Work> Works { get; set; }
    }
}
