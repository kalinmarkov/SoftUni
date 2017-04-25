using AutoTrader.Data;
using AutoTrader.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoTrader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new CarsDbContext();

            var cars = db.Cars
                .Where(c => !c.IsSold)
                .OrderByDescending(c => c.Id)
                .Take(3)
                .Select(c => new CarListingModel
                {
                    Id = c.Id,
                    ImageUrl = c.ImageUrl,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year
                })
                .ToList();

            return View(cars);
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Help me to choose";

            return View();
        }

        public ActionResult CreateReview()
        {

            var db = new CarsDbContext();

            var post = db.Posts.OrderByDescending(p => p.Date).Take(3);

            return View(post.ToList());
        }

        public ActionResult TopMarques()
        {
            ViewBag.Message = "Help others with more info";

            return View();
        }
    }
}