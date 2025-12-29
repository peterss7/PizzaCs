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
    public DbSet<AccountEfc> Accounts { get; set; }
    public DbSet<MenuItemEfc> MenuItems { get; set; }
    public DbSet<IngredientEfc> Ingredients { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountEfc>(e =>
        {
            e.HasIndex(x => x.AccountNumber).IsUnique();
            e.Property(x => x.AccountNumber).HasMaxLength(32).IsRequired();
        });
    }
}
