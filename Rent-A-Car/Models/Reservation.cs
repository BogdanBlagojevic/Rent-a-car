using System;

namespace Rent_A_Car.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public DateTime DateOfPickup { get; set; }
        public DateTime DateOfReturn { get; set; }
        public Nullable<int> TotalPrice { get; set; }

    }
}
