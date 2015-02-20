using Band.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Band.Adapters
{
    public interface IBandAdapter
    {
        List<BandViewModel> GetBands(string userId);

        void CreateBand(BandViewModel model, string userId);

        BandViewModel GetBand(int bandId);
        void Update(BandViewModel model);
   
    }
}