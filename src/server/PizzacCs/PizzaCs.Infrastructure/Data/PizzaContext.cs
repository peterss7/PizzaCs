using Microsoft.EntityFrameworkCore;
using PizzaCs.Infrastructure.Models.Entities;

namespace PizzaCs.Infrastructure.Data;

public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
    {
        if (options is null)
        {
            throw new ArgumentNullException(nameof(options));
        }
    }

    public DbSet<UserEfc> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEfc>()
         .HasIndex(u => u.UserId)
         .IsUnique();
    }
}
