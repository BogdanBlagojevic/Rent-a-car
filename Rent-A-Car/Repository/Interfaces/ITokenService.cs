using Rent_A_Car.Models;
using System.Threading.Tasks;

namespace Rent_A_Car.Repository.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
