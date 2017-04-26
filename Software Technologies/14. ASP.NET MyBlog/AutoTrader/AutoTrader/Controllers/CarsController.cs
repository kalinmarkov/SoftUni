using AutoTrader.Data;
using AutoTrader.Models.Cars;
using AutoTrader.Models.Leasing;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AutoTrader.Controllers
{
    public class CarsController : Controller
    {
        public ActionResult All(
            int page = 1, 
            string user = null,
            string search = null)
        {
            var db = new CarsDbContext();

            var pageSize = 5;

            var carsQuery = db.Cars.AsQueryable();

            if (search != null)
            {
                carsQuery = carsQuery
                    .Where(c => c.Make.ToLower().Contains(search.ToLower()) ||
                    c.Model.ToLower().Contains(search.ToLower()));
            }

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
                    Price = c.Price,
                    IsSold = c.IsSold
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

                var car = new Car
                {
                    VehicleType = CarModel.VehicleType,
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
                    Id = c.Id,
                    Color = c.Color,
                    Engine = c.Engine,
                    EngineType = c.EngineType,
                    ImageUrl = c.ImageUrl,
                    Make = c.Make,
                    Model = c.Model,
                    Power = c.Power,
                    Price = c.Price,
                    Year = c.Year,
                    IsSold = c.IsSold,
                    TotalRents = c.Leasings.Count(),
                    ContactInformation = c.Owner.Email
                })
                .FirstOrDefault();

            if (car == null)
            {
                return HttpNotFound();
            }

            return View(car);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Sold(LeasingCarModel leasingCarModel)
        {
            if (leasingCarModel.Months < 1 || leasingCarModel.Months > 24)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var db = new CarsDbContext();

            var car = db.Cars
                .Where(c => c.Id == leasingCarModel.CarId)
                .Select(c => new
                {
                    c.IsSold,
                    c.Price,
                    c.ImageUrl,
                    FullName = c.Make + " " + c.Model + " (" + c.Year + ")"
                })
                .FirstOrDefault();

            if (car == null || car.IsSold)
            {
                return HttpNotFound();
            }

            leasingCarModel.CarName = car.FullName;
            leasingCarModel.CarImageUrl = car.ImageUrl;
            leasingCarModel.Price = car.Price;
            leasingCarModel.TotalPrice = car.Price / leasingCarModel.Months;

            return View(leasingCarModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Sold(int carId, int months)
        {
            var db = new CarsDbContext();

            var car = db.Cars
                .Where(c => c.Id == carId)
                .FirstOrDefault();

            var userId = this.User.Identity.GetUserId();

            if (car == null || car.IsSold || car.OwnerId == userId)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var leasing = new Leasing
            {
                CarId = carId,
                Months = months,
                SoldOn = DateTime.Now,
                UserId = userId,
                TotalPrice = car.Price
            };

            car.IsSold = true;

            db.Leasings.Add(leasing);
            db.SaveChanges();

            return RedirectToAction("Details", new { id = car.Id });
        }
    }
}