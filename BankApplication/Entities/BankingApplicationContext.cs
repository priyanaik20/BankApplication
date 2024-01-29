using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BankApplication.Entities;

public partial class BankingApplicationContext : DbContext
{
    public BankingApplicationContext()
    {
    }

    public BankingApplicationContext(DbContextOptions<BankingApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=BankApplicationConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.Property(e => e.BranchId)
                .ValueGeneratedNever()
                .HasColumnName("BranchID");
            entity.Property(e => e.BranchCity).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
