using Microsoft.EntityFrameworkCore;
using Lab4.Models;

namespace Lab4.Data
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options) 
        { 
        }

        public DbSet<NewsBoard> NewsBoards { get; set; }
        public DbSet<Client> Clients { get; set; }

        //added to resolved error on line 51 in DbInitializer
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<NewsBoard>().ToTable("NewsBoard");
            modelBuilder.Entity<Subscription>().HasKey(c => new { c.ClientId, c.NewsBoardId });

        }

    }
}
