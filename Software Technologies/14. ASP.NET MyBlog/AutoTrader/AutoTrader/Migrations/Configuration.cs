namespace AutoTrader.Migrations
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<AutoTrader.Data.CarsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "AutoTrader.Data.CarsDbContext";
        }

        protected override void Seed(CarsDbContext context)
        {
            if (context.Cars.Any())
            {
                return;
            }

            var user = context.Users.FirstOrDefault();

            if (user == null)
            {
                return;
            }

            context.Cars.Add(new Car
            {
                Make = "BMW",
                Model = "650i",
                Color = "Black",
                Engine = 5.0,
                EngineType = EngineType.Petrol,
                ImageUrl = "http://www.bimmerfest.com/forums/image.php?u=211879&type=sigpic&dateline=1288824921",
                Power = 500,
                Price = 15000,
                Year = 2008,
                OwnerId = user.Id
            });

            context.Cars.Add(new Car
            {
                Make = "BMW",
                Model = "650i",
                Color = "White",
                Engine = 5.0,
                EngineType = EngineType.Petrol,
                ImageUrl = "https://s-media-cache-ak0.pinimg.com/originals/0b/18/25/0b1825b6bfbe5f01be870575bf54e82a.jpg",
                Power = 530,
                Price = 12000,
                Year = 2007,
                OwnerId = user.Id
            });

            context.Cars.Add(new Car
            {
                Make = "VW",
                Model = "Scirocco",
                Color = "Blue",
                Engine = 3.0,
                EngineType = EngineType.Diesel,
                ImageUrl = "http://o.aolcdn.com/dims-global/dims3/GLOB/legacy_thumbnail/750x422/quality/95/http://www.blogcdn.com/slideshows/images/slides/282/504/5/S2825045/slug/l/01-2014-vw-scirocco-r-fd-1.jpg",
                Power = 230,
                Price = 10000,
                Year = 2007,
                OwnerId = user.Id
            });
        }
    }
}
