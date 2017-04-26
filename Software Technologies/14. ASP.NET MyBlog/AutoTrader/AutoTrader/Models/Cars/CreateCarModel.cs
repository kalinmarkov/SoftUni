using AutoTrader.Data;
using AutoTrader.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoTrader.Models.Cars
{
    public class CreateCarModel
    {
        [Display(Name = "Vehicle type")]
        [ScaffoldColumn(false)]
        public VehicleType VehicleType { get; set; }

        [Required]
        [MaxLength(40)]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Range(1950, 2017)]
        public int Year { get; set; }

        public string Color { get; set; }

        public double Engine { get; set; }

        [Display(Name = "Engine type")]
        [ScaffoldColumn(false)]
        public EngineType EngineType { get; set; }

        public int? Power { get; set; }

        [Display(Name = "Price in BGN")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        [ImageUrl]
        public string ImageUrl { get; set; }
    }
}