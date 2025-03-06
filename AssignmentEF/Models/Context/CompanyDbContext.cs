using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AssignmentEF.Models.Context
{
    public class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; Database = CompanyDb; Trusted_Connection= True; Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            //modelBuilder.Entity<Employee>(builder =>
            //{
            //        builder.HasDiscriminator<string>("Type")
            //        .HasValue<FullTimeEmployee>("Full")
            //        .HasValue<PartTimeEmployee>("Part");
            //});

            //modelBuilder.Entity<FullTimeEmployee>(builder =>
            //{
            //    builder.Property(e => e.MonthlySalary)
            //    .HasColumnType("decimal(18,2)");
            //});

            //modelBuilder.Entity<PartTimeEmployee>(builder =>
            //{
            //    builder.Property(e => e.HourlyRate)
            //    .HasColumnType("decimal(18,2)");
            //}); 
            #endregion
            #region TPT
            //modelBuilder.Entity<Employee>(builder =>
            //{
            //    builder.ToTable("Employees");
            //});

            //modelBuilder.Entity<FullTimeEmployee>(builder =>
            //{
            //    builder.ToTable("FullTimeEmployees");

            //    builder.Property(e => e.MonthlySalary)
            //    .HasColumnType("decimal(18,2)");
            //});

            //modelBuilder.Entity<PartTimeEmployee>(builder =>
            //{
            //    builder.ToTable("PartTimeEmployees");

            //    builder.Property(e => e.HourlyRate)
            //    .HasColumnType("decimal(18,2)");
            //});
            #endregion
            #region TPCC
            //modelBuilder.Entity<FullTimeEmployee>(builder =>
            //{
            //    builder.ToTable("FullTimeEmployees")
            //    .HasKey(e => e.EmployeeId);
            //    builder.HasData(new FullTimeEmployee
            //    {
            //        Name = "Test",
            //        Address = "Cairo",
            //        EmployeeId = 10 ,
            //        Email = "test@gmail.com",
            //        MonthlySalary = 6500.00m

            //    });

            //    builder.Property(e => e.MonthlySalary)
            //    .HasColumnType("decimal(18,2)");
            //});

            //modelBuilder.Entity<PartTimeEmployee>(builder =>
            //{
            //    builder.ToTable("PartTimeEmployees")
            //    .HasKey(e => e.EmployeeId);

            //    builder.Property(e => e.HourlyRate)
            //    .HasColumnType("decimal(18,2)");
        //});
            #endregion

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
