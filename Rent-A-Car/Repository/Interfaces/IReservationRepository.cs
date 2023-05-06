using Rent_A_Car.Models;
using Rent_A_Car.Models.DTO;
using System.Linq;

namespace Rent_A_Car.Repository.Interfaces
{
    public interface IReservationRepository
    {
        IQueryable<Reservation> GetAll();
        Reservation GetOne(int id);
        void Create(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(Reservation reservation);
        IQueryable<Reservation> FilterByDateOfPickup(ReservationDatePickDTO dto);
        IQueryable<Reservation> FilterByDateOfReturn(ReservationDateReturnDTO dto);
        IQueryable<Reservation> FilterByTotalPrice(ReservationTotalPriceDTO dto);
    }
}
