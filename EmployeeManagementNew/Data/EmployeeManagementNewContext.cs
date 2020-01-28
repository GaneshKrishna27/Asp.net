

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementNew.Models;

namespace EmployeeManagementNew.Data
{
    public class EmployeeManagementNewContext : DbContext
    {
        public EmployeeManagementNewContext (DbContextOptions<EmployeeManagementNewContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagementNew.Models.Employee> Employee { get; set; }
    }
}
