using Rent_A_Car.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rent_A_Car.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        void Update(AppUser user);

    }
}
