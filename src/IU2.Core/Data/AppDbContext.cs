using IU2.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace IU2.Core.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Issue> Issues => Set<Issue>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Issue>().Property(i => i.Status).HasConversion<string>();
        modelBuilder.Entity<Issue>().Property(i => i.Priority).HasConversion<string>();
        modelBuilder.Entity<Issue>().Property(i => i.Category).HasConversion<string>();
    }
}
