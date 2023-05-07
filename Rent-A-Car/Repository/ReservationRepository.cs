using Microsoft.EntityFrameworkCore;
using Rent_A_Car.Models;
using Rent_A_Car.Models.DTO;
using Rent_A_Car.Repository.Interfaces;
using System;
using System.Linq;

namespace Rent_A_Car.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _context;

        public ReservationRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Reservation> GetAll()
        {
            return _context.Reservations.OrderBy(r => r.TotalPrice);
        }

        public Reservation GetOne(int id)
        {
            return _context.Reservations.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Reservation res)
        {
            _context.Reservations.Add(res);
            foreach (Car car in _context.Cars)
            {
                if (car.Id == res.CarId)
                {
                    res.TotalPrice = (int)(res.DateOfReturn - res.DateOfPickup).TotalDays * car.Price;
                }
            }
            _context.SaveChanges();
        }

        public void Update(Reservation res)
        {
            _context.Entry(res).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Delete(Reservation res)
        {
            _context.Remove(res);
            _context.SaveChanges();
        }

        public IQueryable<Reservation> FilterByDateOfPickup(ReservationDatePickDTO dto)
        {
            return _context.Reservations.Where(c => c.DateOfPickup == dto.Date);
        }
        public IQueryable<Reservation> FilterByDateOfReturn(ReservationDateReturnDTO dto)
        {
            return _context.Reservations.Where(c => c.DateOfReturn == dto.Date);
        }
        public IQueryable<Reservation> FilterByTotalPrice(ReservationTotalPriceDTO dto)
        {
            return _context.Reservations.Where(c => c.TotalPrice >= dto.Min && c.TotalPrice <= dto.Max);
        }

    }
}
