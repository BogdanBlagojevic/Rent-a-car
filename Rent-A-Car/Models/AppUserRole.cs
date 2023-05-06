using Microsoft.AspNetCore.Identity;

namespace Rent_A_Car.Models
{
    public class AppUserRole:IdentityUserRole<int>
    {
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}
