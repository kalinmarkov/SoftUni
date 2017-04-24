using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrader.Models.Leasing
{
    public class UserLeasingModel
    {
        public int Months { get; set; }

        public DateTime SoldOn { get; set; }

        public decimal TotalPrice { get; set; }

        public string CarName { get; set; }

        public string CarImgUrl { get; set; }
    }
}