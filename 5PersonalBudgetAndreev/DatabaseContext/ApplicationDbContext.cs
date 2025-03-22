using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalBudgetAndreev.Entities;


namespace PersonalBudgetAndreev.DatabaseContext;

public class ApplicationDbContext: DbContext
{
    public DbSet<TransactionEntity> Transactions { get; set; } = null!;

    public ApplicationDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TransactionEntity>(x =>
        {
            x.HasKey(t => t.Id);

            x.Property(t => t.Title).HasMaxLength(32);
            x.HasIndex(t => t.Title).IsUnique();
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine(FileSystem.Current.AppDataDirectory, "PersonalBudgetDb.db"); // создание пути, где будет создана БД
        optionsBuilder.UseSqlite($"Filename={dbPath}"); // создание подключения к базе данных
    }
}