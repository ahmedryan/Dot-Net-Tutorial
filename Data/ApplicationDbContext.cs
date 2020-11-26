using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Tutorial_1.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Tutorial_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
