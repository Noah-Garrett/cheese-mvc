using CheeseMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {
        public DbSet<Cheese> Cheeses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=CheeseMVC.db");


        public DbSet<CheeseCategory> Categories { get; set; }
        // public CheeseDbContext(DbContextOptions<CheeseDbContext> options)
        //     : base(options)
        //{ }

    }
}