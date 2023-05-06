using Microsoft.EntityFrameworkCore;
using Rent_A_Car.Models;
using Rent_A_Car.Models.DTO.CarDTO;
using Rent_A_Car.Repository.Interfaces;
using System.Linq;

namespace Rent_A_Car.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _context;

        public CarRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Car> GetAll()
        {
            return _context.Cars.OrderBy(b => b.Brand);
        }

        public Car GetOne(int id)
        {
            return _context.Cars.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void Update(Car car)
        {
            _context.Entry(car).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Delete(Car car)
        {
            _context.Remove(car);
            _context.SaveChanges();
        }

        public IQueryable<Car> FilterByBrand(CarBrandDTO dto)
        {
            return _context.Cars.Where(c => c.Brand == dto.Brand).OrderBy(o => o.Price);
        }
        public IQueryable<Car> FilterByModel(CarModelDTO dto)
        {
            return _context.Cars.Where(c => c.Model == dto.Model).OrderBy(o => o.Price);
        }
        public IQueryable<Car> FilterByDate(CarDateDTO dto)
        {
            return _context.Cars.Where(c => c.Date == dto.Date).OrderBy(o => o.Price);
        }
        public IQueryable<Car> FilterByPrice(CarPriceDTO dto)
        {
            return _context.Cars.Where(o => o.Price >= dto.Min && o.Price <= dto.Max).OrderBy(o => o.Price);
        }
        public IQueryable<Car> FilterByGearshift(CarGearshiftDTO dto)
        {
            return _context.Cars.Where(c => c.GearShift == dto.Gearshift).OrderBy(o => o.Price);
        }
        public IQueryable<Car> FilterByCountry(CarCountryDTO dto)
        {
            return _context.Cars.Where(c => c.Country == dto.Country);
        }
        public IQueryable<Car> FilterByCity(CarCityDTO dto)
        {
            return _context.Cars.Where(c => c.City == dto.City);
        }
    }
}
