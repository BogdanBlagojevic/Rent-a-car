using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Models;
using Rent_A_Car.Models.DTO.CarDTO;
using Rent_A_Car.Repository.Interfaces;

namespace Rent_A_Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_carRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            Car car = _carRepository.GetOne(id);

            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _carRepository.Create(car);

            return CreatedAtAction("GetOne", new { id = car.Id }, car);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult Update(int id, Car car)
        {

            if (id != car.Id)
            {
                return BadRequest();
            }

            try
            {
                _carRepository.Update(car);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(car);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Car car = _carRepository.GetOne(id);
            if (car == null)
            {
                return NotFound();
            }

            _carRepository.Delete(car);
            return NoContent();
        }
        [Route("/api/byBrand")]
        [HttpPost]
        public IActionResult FilterByBrand(CarBrandDTO dto)
        {
            return Ok(_carRepository.FilterByBrand(dto));
        }
        [Route("/api/byModel")]
        [HttpPost]
        public IActionResult FilterByModel(CarModelDTO dto)
        {
            return Ok(_carRepository.FilterByModel(dto));
        }
        [Route("/api/byDate")]
        [HttpPost]
        public IActionResult FilterByDate(CarDateDTO dto)
        {
            return Ok(_carRepository.FilterByDate(dto));
        }
        [Route("/api/byPrice")]
        [HttpPost]
        public IActionResult FilterByPrice(CarPriceDTO dto)
        {
            return Ok(_carRepository.FilterByPrice(dto));
        }
        [Route("/api/byGearshift")]
        [HttpPost]
        public IActionResult FilterByGearshift(CarGearshiftDTO dto)
        {
            return Ok(_carRepository.FilterByGearshift(dto));
        }
        [Route("/api/byCountry")]
        [HttpPost]
        public IActionResult FilterByCountry(CarCountryDTO dto)
        {
            return Ok(_carRepository.FilterByCountry(dto));
        }
        [Route("/api/byCity")]
        [HttpPost]
        public IActionResult FilterByCity(CarCityDTO dto)
        {
            return Ok(_carRepository.FilterByCity(dto));
        }
    }
}
