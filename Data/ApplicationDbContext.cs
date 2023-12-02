using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<TotalPayoutsPerEmployeeViewModel> TotalPayoutsPerEmployee { get; set; }
        public DbSet<TotalPayoutsPerEmployeeTypeViewModel> TotalPayoutsPerEmployeeType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TotalPayoutsPerEmployeeViewModel>().HasNoKey();
            modelBuilder.Entity<TotalPayoutsPerEmployeeTypeViewModel>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}