using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Rent_A_Car.Repository.Interfaces;
using Rent_A_Car.Models;
using Rent_A_Car.Models.DTO;

namespace Rent_A_Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;

        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }


        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO regDTO)
        {
            if (await UserExistsUsername(regDTO.Username)) return BadRequest("Username already exists.");
            if (await UserExistsEmail(regDTO.Email)) return BadRequest("Account with that Email already exists.");

            var user = new AppUser
            {
                UserName = regDTO.Username,
                Email = regDTO.Email,
                Name = regDTO.Name,
                Surname = regDTO.Surname,
                
            };

            var result = await _userManager.CreateAsync(user, regDTO.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Customer");

            if (!roleResult.Succeeded) return BadRequest(result.Errors);

            return new UserDTO
            {
                Username = user.UserName,
                Email = user.Email,
                Token = await _tokenService.CreateToken(user),
                Name = user.Name,
                Surname = user.Surname,
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.Email == loginDTO.Email);

            if (user == null) return Unauthorized("Invalid username");

            var result = await _userManager.CheckPasswordAsync(user, loginDTO.Password);

            if (!result) return Unauthorized();

            return new UserDTO
            {
                Username = user.UserName,
                Email = user.Email,
                Token = await _tokenService.CreateToken(user),
                Name = user.Name,
                Surname = user.Surname,
            };
        }

        private async Task<bool> UserExistsUsername(string username)
        {
            return await _userManager.Users.AnyAsync(x => x.UserName == username);
        }

        private async Task<bool> UserExistsEmail(string email)
        {
            return await _userManager.Users.AnyAsync(x => x.Email == email);
        }
    }
}
