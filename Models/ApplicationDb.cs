using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ApplicationDb: DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
