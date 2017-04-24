using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrader.Data
{
    public class Leasing
    {
        public int Id { get; set; }

        public int Months { get; set; }

        public DateTime SoldOn { get; set; }

        public decimal TotalPrice { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int CarId { get; set; }

        public virtual Car Car { get; set; }
    }
}