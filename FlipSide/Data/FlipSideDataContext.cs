using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlipSide.Models;

namespace FlipSide.Models
{
    public class FlipSideDataContext : DbContext
    {
        public FlipSideDataContext (DbContextOptions<FlipSideDataContext> options)
            : base(options)
        {
        }

        public DbSet<FlipSide.Models.Story> Story { get; set; }
        public DbSet<FlipSide.Models.Topics> Topics { get; set; }
    }
}
