using Microsoft.AspNetCore.Identity;
using SuperShopBrunoFerreira.Data.Entity;
using System.Threading.Tasks;

namespace SuperShopBrunoFerreira.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsycn(User user, string password);
    }
}
