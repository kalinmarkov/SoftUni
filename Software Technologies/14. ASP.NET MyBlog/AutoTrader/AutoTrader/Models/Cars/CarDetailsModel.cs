﻿using AutoTrader.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoTrader.Models.Cars
{
    public class CarDetailsModel
    {
        public string Make { get; set; }
        
        public string Model { get; set; }
        
        public int Year { get; set; }

        public string Color { get; set; }

        public double Engine { get; set; }

        public EngineType EngineType { get; set; }

        public int? Power { get; set; }

        public decimal Price { get; set; }
        
        public string ImageUrl { get; set; }

        public string ContactInformation { get; set; }
    }
}