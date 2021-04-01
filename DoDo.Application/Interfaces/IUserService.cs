using DoDo.Application.Models;
using DoDo.Domain.Entities;
using System.Threading.Tasks;

namespace DoDo.Application.Interfaces
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthenticationModel> RefreshTokenAsync(string token);
        bool RevokeToken(string token);
        ApplicationUser GetById(string id);
    }
}
