using Employees.Application.Interfaces.contexts;
using Employees.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Persistence.Contexts
{
    public class EmployeeContext:DbContext,IEmployeesContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "EmployeesDb");
        }
        public DbSet<Employee> Employees { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasIndex(u => new { u.Name , u.DateOfBirth }).IsUnique(true);
        }

    }
}
