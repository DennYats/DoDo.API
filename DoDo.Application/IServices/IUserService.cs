using DoDo.Application.Models;
using DoDo.Domain.Entities;
using System.Threading.Tasks;

namespace DoDo.Application.IServices
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthenticationModel> RefreshTokenAsync(string token);
        bool RevokeToken(string token);
        DoDoUser GetById(string id);
    }
}
