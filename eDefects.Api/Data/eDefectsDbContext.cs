using eDefectsPilotBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDefectsPilotBackend.Data
{
    public class eDefectsDbContext : DbContext
    {
        public eDefectsDbContext(DbContextOptions<eDefectsDbContext> options) : base(options)
        {

        }
 
         public DbSet<Defect> Defects { get; set; }
        
    }
}
