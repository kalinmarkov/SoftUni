using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrader.Models.Leasing
{
    public class LeasingCarModel
    {
        public int CarId { get; set; }

        public string CarName { get; set; }

        public string CarImageUrl { get; set; }

        public int Months { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

    }
}