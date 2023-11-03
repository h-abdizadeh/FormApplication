using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using BookStore.Models;

namespace BookStore.Database;

public class DatabaseContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Group> Groups { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Group>().ToTable("Groups");
        //modelBuilder.Entity<Book>().ToTable("Books");

        List<Group> groups = new List<Group>()
        {
            new Group(){ Id = 1, Name = "آموزشی" },
            new Group(){ Id = 2, Name = "عمومی" },
            new Group(){ Id = 3, Name = "شعر" }
        };

        modelBuilder.Entity<Group>().HasData(groups);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //1
        //var connection = new SqliteConnectionStringBuilder
        //{
        //    DataSource = "myDb.db"
        //};

        //optionsBuilder.UseSqlite(new SqliteConnection(connection.ToString()));

        //2
        optionsBuilder.UseSqlite($"Data Source ={Application.StartupPath}\\myDb.db");
    }



}
