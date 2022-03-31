#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using keyzelrazorpages.Pages.Story;

namespace keyzelrazorpages.Data
{
    public class keyzelrazorpagesContext : DbContext
    {
        public keyzelrazorpagesContext (DbContextOptions<keyzelrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<keyzelrazorpages.Pages.Story.Story> Story { get; set; }
    }
}
