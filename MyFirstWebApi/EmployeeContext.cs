using Microsoft.EntityFrameworkCore;
using MyFirstWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApi
{
    public class EmployeeContext : DbContext //derived to communicate with database for CRUD
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
