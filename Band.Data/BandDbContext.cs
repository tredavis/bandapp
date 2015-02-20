using Band.Data.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Band.Data
{
    public class BandDbContext : IdentityDbContext<User>
    {
        public BandDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Bands> Bands { get; set; }
        public static BandDbContext Create()
        {
            return new BandDbContext();
        }
    }
}
