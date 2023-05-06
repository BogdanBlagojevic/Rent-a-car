using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Rent_A_Car.Models
{
    public class AppRole:IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
