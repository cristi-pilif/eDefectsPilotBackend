using eDefects.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDefects.Api.Data
{
    public class EDefectsDbContext : DbContext
    {
        public EDefectsDbContext(DbContextOptions<EDefectsDbContext> options) : base(options)
        {

        }
 
         public DbSet<Defect> Defects { get; set; }
         public DbSet<Team> Teams { get; set; }

    }
}
