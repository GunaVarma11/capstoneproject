using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capstoneproject.Models;

namespace Capstoneproject.Data
{
    public class InfoDbContext : DbContext
    {
        public InfoDbContext (DbContextOptions<InfoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Capstoneproject.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<Capstoneproject.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<Capstoneproject.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
