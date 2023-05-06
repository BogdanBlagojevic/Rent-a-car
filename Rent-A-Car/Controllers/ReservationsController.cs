using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Models;
using Rent_A_Car.Models.DTO;
using Rent_A_Car.Repository.Interfaces;

namespace Rent_A_Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationsController(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_reservationRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            Reservation res = _reservationRepository.GetOne(id);

            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [Authorize(Roles = "Admin,Customer")]
        [HttpPost]
        public IActionResult Create(Reservation res)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (res.DateOfPickup > res.DateOfReturn)
            {
                return BadRequest("Date of pickup can not be greater than date of return!");
            }
            _reservationRepository.Create(res);

            return CreatedAtAction("GetOne", new { id = res.Id }, res);
        }

        [Authorize(Roles = "Admin,Customer")]
        [HttpPut("{id}")]
        public IActionResult Update(int id, Reservation res)
        {

            if (id != res.Id)
            {
                return BadRequest();
            }

            try
            {
                _reservationRepository.Update(res);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(res);
        }

        [Authorize(Roles = "Admin,Customer")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Reservation res = _reservationRepository.GetOne(id);
            if (res == null)
            {
                return NotFound();
            }

            _reservationRepository.Delete(res);
            return NoContent();
        }

        [Authorize(Roles = "Admin,Customer")]
        [Route("/api/byDatePick")]
        [HttpPost]
        public IActionResult FilterByDateOfPickup(ReservationDatePickDTO dto)
        {
            return Ok(_reservationRepository.FilterByDateOfPickup(dto));
        }

        [Authorize(Roles = "Admin,Customer")]
        [Route("/api/byDateReturn")]
        [HttpPost]
        public IActionResult FilterByDateOfReturn(ReservationDateReturnDTO dto)
        {
            return Ok(_reservationRepository.FilterByDateOfReturn(dto));
        }

        [Authorize(Roles = "Admin,Customer")]
        [Route("/api/byTotalPrice")]
        [HttpPost]
        public IActionResult FilterByTotalPrice(ReservationTotalPriceDTO dto)
        {
            return Ok(_reservationRepository.FilterByTotalPrice(dto));
        }
    }
}
