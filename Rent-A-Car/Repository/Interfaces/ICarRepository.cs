using Rent_A_Car.Models;
using Rent_A_Car.Models.DTO.CarDTO;
using System.Linq;

namespace Rent_A_Car.Repository.Interfaces
{
    public interface ICarRepository
    {
        IQueryable<Car> GetAll();
        Car GetOne(int id);
        void Create(Car car);
        void Update(Car car);
        void Delete(Car car);
        IQueryable<Car> FilterByBrand(CarBrandDTO dto);
        IQueryable<Car> FilterByModel(CarModelDTO dto);
        IQueryable<Car> FilterByDate(CarDateDTO dto);
        IQueryable<Car> FilterByPrice(CarPriceDTO dto);
        IQueryable<Car> FilterByGearshift(CarGearshiftDTO dto);
        IQueryable<Car> FilterByCountry(CarCountryDTO dto);
        IQueryable<Car> FilterByCity(CarCityDTO dto);
    }
}
