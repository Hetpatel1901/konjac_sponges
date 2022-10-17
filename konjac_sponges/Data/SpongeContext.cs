using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using konjac_sponges.Models;
// File: SpongeContext.cs
// Author Name: Het Natvarbhai Patel
// Student i'd: 0805024

namespace konjac_sponges.Data
{
    public class SpongeContext : DbContext
    {
        public SpongeContext(DbContextOptions<SpongeContext> options) : base(options)
        {

        }
        public DbSet<SpongeClass> SpongeClass { get; set; }
    }
}
