using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrader.Models.Renting
{
    public class RentCarModel
    {
        public int CarId { get; set; }

        public string CarName { get; set; }

        public string CarImageUrl { get; set; }

        public int Days { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

    }
}