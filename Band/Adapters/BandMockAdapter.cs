using Band.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Band.Adapters
{
    public class BandMockAdapter : IBandAdapter
    {
        public void CreateBand(BandViewModel model, string userId)
        {

        }

        public BandViewModel GetBand(int BookId)
        {
            throw new NotImplementedException();
        }

        public List<BandViewModel> GetBands(string userId)
        {
            List<BandViewModel> models = new List<BandViewModel>();

            models.Add(new BandViewModel
            {
                BandId = 1,
                BandName = "Breathe Carolina",
                Rating = 10,
                Genre = "HardRock"

            });

            models.Add(new BandViewModel
            {
                BandId = 2,
                BandName = "OVOXO",
                Rating = 9,
                Genre = "Rap"
            });

            return models;

        }

        public void Update(BandViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}