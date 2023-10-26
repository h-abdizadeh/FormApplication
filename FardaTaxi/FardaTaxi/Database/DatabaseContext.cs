using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using FardaTaxi.Models;

namespace FardaTaxi.Database;

public class DatabaseContext:DbContext
{
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder option)
    {
        option.UseSqlite($"data source={Application.StartupPath}\\myDB.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { 
        //base.OnModelCreating(modelBuilder);
    }
}
