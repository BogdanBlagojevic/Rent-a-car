using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Rent_A_Car.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
