using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using konjac_sponges.Models;

namespace konjac_sponges.Data
{
    public class konjac_spongesContext : DbContext
    {
        public konjac_spongesContext (DbContextOptions<konjac_spongesContext> options)
            : base(options)
        {
        }

        public DbSet<konjac_sponges.Models.SpongeClass> SpongeClass { get; set; }
    }
}
