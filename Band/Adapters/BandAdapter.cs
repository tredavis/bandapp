using Band.Data;
using Band.Data.Model;
using Band.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Band.Adapters
{
    public class BandAdapter : IBandAdapter
    {
        public void CreateBand(BandViewModel model, string userId)
        {
            using (BandDbContext db = new BandDbContext())
            {
                Bands dbBand = new Bands
                {
                    BandName = model.BandName,
                    Rating = model.Rating,
                    Genre = model.Genre,
                    UserId = userId

                };
                db.Bands.Add(dbBand);
                //This actually saves the changes. This is bringing your groceries back from the store and actually saving them.
                db.SaveChanges();
            }
        }

        public BandViewModel GetBand(int BandId)
        {
            throw new NotImplementedException();
        }

        public List<BandViewModel> GetBands(string userId)
        {         
            List<BandViewModel> models = null;
            using (BandDbContext db = new BandDbContext())
            {
                // for every Book in the database, I want you to create a Book view model for it.
                models = db.Bands
                        //.Where(m => m.UserId == userId)
                        .Select(m => new BandViewModel
                        {
                            BandName = m.BandName,
                            Genre = m.Genre,
                            Rating = m.Rating,
                        }).ToList();

            }
            return models;
        }

        public void Update(BandViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}