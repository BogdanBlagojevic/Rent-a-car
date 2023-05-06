using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_A_Car.Models;
using Rent_A_Car.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rent_A_Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsersAsync()
        {

            return Ok(await _userRepository.GetUsersAsync());
        }

        [Authorize(Roles = "Customer,Admin")]
        [HttpGet("{id}")]
        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }
    }
}
