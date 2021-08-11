using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToysWorld.Models;

namespace ToysWorld.Data
{
    public class ToysWorldContext : DbContext
    {
        public ToysWorldContext (DbContextOptions<ToysWorldContext> options)
            : base(options)
        {
        }

        public DbSet<ToysWorld.Models.Target> Target { get; set; }

        public DbSet<ToysWorld.Models.Offers> Offers { get; set; }

        public DbSet<ToysWorld.Models.Toys> Toys { get; set; }

        public DbSet<ToysWorld.Models.Sales> Sales { get; set; }
    }
}
