using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using AutoTrader.Models;

namespace AutoTrader.Data
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Cars = new HashSet<Car>();
            this.Leasings = new HashSet<Leasing>();
            this.Posts = new HashSet<Post>();
        }

        public virtual ICollection<Car> Cars { get; set; }

        public virtual ICollection<Leasing> Leasings { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    
}