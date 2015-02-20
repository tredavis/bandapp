using Band.Data.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Band.Data
{
    public class Seeder
    {
        public static void Seed(BandDbContext context)
        {
            UserStore<User> store = new UserStore<User>(context);
            UserManager<User> manager = new UserManager<User>(store);

            User tre = manager.FindByEmail("davis@gmail.com");

            if (tre == null)
            {
                tre = new User
                {
                    Email = "davis@gmail.com",
                    UserName = "davis@gmail.com"
                };

                manager.Create(tre, "123456");
            }
            context.Bands.AddOrUpdate(m => m.BandName,
                new Bands
                {
                    BandName = "Muse",
                    Genre = "Rock",
                    Rating = 7,
                    User = tre
                },
                new Bands
                { BandName = "Korn", Genre = "Rock", Rating = 12, User = tre },

                 new Bands
                 { BandName = "Ishi", Genre = "Rock", Rating = 6, User = tre });


        }

    }
}

