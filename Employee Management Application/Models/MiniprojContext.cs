using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Employee_Mini_Proj.Models;

public partial class MiniprojContext : DbContext
{
    public MiniprojContext()
    {
    }

    public MiniprojContext(DbContextOptions<MiniprojContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=miniproj;Integrated Security=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__employee__AF4CE8657091A7E4");

            entity.ToTable("employees");

            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fname");
            entity.Property(e => e.Gender)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Lname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lname");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Position)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.Salary).HasColumnName("salary");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
