using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using BLL.Repositories;
using BLL.Security;
using userServices.Services.Communication;

namespace userServices.Services
{
    public class UsersProfiService :IUsersProfiService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IUsersProfiRepository _usersProfiRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasher _passwordHasher;

        public UsersProfiService(IUsersRepository usersRepository, IUsersProfiRepository usersProfiRepository,
                                        IUnitOfWork unitOfWork, IPasswordHasher passwordHasher)
        {
            this._usersRepository = usersRepository;
            this._usersProfiRepository = usersProfiRepository;
            this._unitOfWork = unitOfWork;
            this._passwordHasher = passwordHasher;
        }

        public async Task<CreateUsersProfiResponse> CreateUserAsync(UsersProfi usersProfi)
        {

            var existingUser = await _usersRepository.FindByEmailAsync(usersProfi.User.Email);
            if (existingUser != null)
            {
                return new CreateUsersProfiResponse(false, "Email already in use.", null, null);
            }

            usersProfi.User.Username = usersProfi.User.Email;
            usersProfi.User.Password = _passwordHasher.HashPassword(usersProfi.User.Password);
            usersProfi.User.UserType = 2;
            usersProfi.User.LastVisited = DateTime.Now;

            await _usersRepository.AddAsync(usersProfi.User);
            int last_insert_id = usersProfi.User.Id;
            usersProfi.UserId = last_insert_id;

            await _usersProfiRepository.AddAsync(usersProfi);
            await _unitOfWork.CompleteAsync();

            return new CreateUsersProfiResponse(true, null, usersProfi.User, usersProfi);

        }

    }
}
