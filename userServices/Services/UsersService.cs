using System.Threading.Tasks;
using DAL.Models;
using BLL.Repositories;

namespace userServices.Services
{
    public class UsersService :IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UsersService(IUsersRepository usersRepository, IUnitOfWork unitOfWork)
        {
            this._usersRepository = usersRepository;
            this._unitOfWork = unitOfWork;
        }

        public async Task<Users> FindByEmailAsync(string email)
        {
            return await _usersRepository.FindByEmailAsync(email);
        }

    }
}
