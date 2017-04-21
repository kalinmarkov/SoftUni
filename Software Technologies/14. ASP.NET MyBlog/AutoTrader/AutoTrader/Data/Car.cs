﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoTrader.Data
{
    public class CarDbContext
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Range(1950, 2017)]
        public int Year { get; set; }

        public string Color { get; set; }

        public double Engine { get; set; }

        public EngineType EngineType { get; set; }

        public int? Power { get; set; }
        
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string OwnerId { get; set; }

        public virtual User Owner { get; set; }
    }
}