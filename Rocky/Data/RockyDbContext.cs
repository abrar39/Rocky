using Microsoft.EntityFrameworkCore;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Data
{
    public class RockyDbContext : DbContext
    {
        public RockyDbContext(DbContextOptions<RockyDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
