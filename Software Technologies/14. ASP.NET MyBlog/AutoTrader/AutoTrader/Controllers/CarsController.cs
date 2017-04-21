using AutoTrader.Data;
using AutoTrader.Models.Cars;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoTrader.Controllers
{
    public class CarsController : Controller
    {
        public ActionResult All(int page = 1, string user = null)
        {
            var db = new CarsDbContext();

            var pageSize = 5;

            var carsQuery = db.Cars.AsQueryable();

            if (user != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Owner.Email == user);
            }

            var cars = carsQuery
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new CarListingModel
                {
                    Id = c.Id,
                    ImageUrl = c.ImageUrl,
                    Make = c.Make,
                    Model = c.Model,
                    Year = c.Year,
                    Price = c.Price
                })
                .ToList();

            ViewBag.CurrentPage = page;

            return View(cars);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreateCarModel CarModel)
        {
            if (CarModel != null && this.ModelState.IsValid)
            {
                var ownerId = this.User.Identity.GetUserId();

                var car = new CarDbContext
                {
                    Make = CarModel.Make,
                    Model = CarModel.Model,
                    Color = CarModel.Color,
                    Engine = CarModel.Engine,
                    EngineType = CarModel.EngineType,
                    ImageUrl = CarModel.ImageUrl,
                    Power = CarModel.Power,
                    Price = CarModel.Price,
                    Year = CarModel.Year,
                    OwnerId = ownerId
                };

                var db = new CarsDbContext();
                db.Cars.Add(car);
                db.SaveChanges();

                return RedirectToAction("Details", new { id = car.Id });
            }

            return View(CarModel);
        }

        public ActionResult Details(int id)
        {
            var db = new CarsDbContext();

            var car = db.Cars
                .Where(c => c.Id == id)
                .Select(c => new CarDetailsModel
                {
                    Color = c.Color,
                    Engine = c.Engine,
                    EngineType = c.EngineType,
                    ImageUrl = c.ImageUrl,
                    Make = c.Make,
                    Model = c.Model,
                    Power = c.Power,
                    Price = c.Price,
                    Year = c.Year,
                    ContactInformation = c.Owner.Email
                })
                .FirstOrDefault();

            if (car == null)
            {
                return HttpNotFound();
            }

            return View(car);
        }
    }
}