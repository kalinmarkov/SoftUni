using AutoTrader.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoTrader.Data
{
    public class CarsDbContext : IdentityDbContext<User>
    {
        public CarsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public virtual IDbSet<Post> Posts { get; set; }

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<Leasing> Leasings { get; set; }

        public static CarsDbContext Create()
        {
            return new CarsDbContext();
        }
    }
}