using BLL.Security.Tokens;
using DAL.Models;
using System.Threading.Tasks;

namespace userServices.Services
{
    public interface ITokenHandler
    {
        Task<AccessToken> CreateAccessToken(Users user);
        Task<RefreshToken> TakeRefreshToken(string token);
        void RevokeRefreshToken(string token);
    }
}
