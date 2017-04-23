﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace AutoTrader.Data
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Cars = new HashSet<Car>();
            this.Rentings = new HashSet<Renting>();
        }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual ICollection<Renting> Rentings { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    
}