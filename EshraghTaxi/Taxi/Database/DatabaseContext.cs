
using Microsoft.EntityFrameworkCore;
using Taxi.Models;

namespace Taxi.Database;

public class DatabaseContext:DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Setting> Settings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"data source={Application.StartupPath}\\myDb.db");
    }

    protected override void OnModelCreating(ModelBuilder Builder)
    {
        //base.OnModelCreating(modelBuilder);
    }
}
