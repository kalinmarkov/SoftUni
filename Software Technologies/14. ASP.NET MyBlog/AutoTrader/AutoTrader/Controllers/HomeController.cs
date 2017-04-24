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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}