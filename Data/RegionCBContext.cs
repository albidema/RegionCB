using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegionCB.Entities;

namespace RegionCB.Data
{
    public class RegionCBContext : DbContext
    {
        public RegionCBContext (DbContextOptions<RegionCBContext> options)
            : base(options)
        {
        }

        public DbSet<RegionCB.Entities.Employee> Employee { get; set; }
    }
}
