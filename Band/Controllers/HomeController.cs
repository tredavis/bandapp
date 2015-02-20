using Band.Adapters;
using Band.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Band.Controllers
{
    public class HomeController : Controller
    {
        private IBandAdapter _adapter;

        public HomeController()
        {
            _adapter = new BandAdapter();
        }
        public HomeController(IBandAdapter adapter)
        {
            _adapter = adapter;
        }
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();

            BandListViewModels model = new BandListViewModels();
            //using the using state it will auto delete this from garbage
            // This also creates a transaction or unit of work

            //MovieDataAdapter adapter = new MovieDataAdapter(); This is commented out because we created the private class above. And instatiated it in the HomeController

            model.Bands = _adapter.GetBands(userId);

            model.UserName = User.Identity.GetUserName();
            model.AverageRating = model.Bands.Average(m => m.Rating);

            return View(model);
        }
        public ActionResult Create()
        {
            BandViewModel model = new BandViewModel();


            return View(model);
        }

        [HttpPost]
        // We pass in the MovieViewModel because that is what they gave to us.
        public ActionResult Create(BandViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            string userId = User.Identity.GetUserId();



            _adapter.CreateBand(model, userId);

            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}