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
    public class UsersCustomerService :IUsersCustomerService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IUsersCustomerRepository _usersCustomerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasher _passwordHasher;

        public UsersCustomerService(IUsersRepository usersRepository, IUsersCustomerRepository usersCustomerRepository,
                                        IUnitOfWork unitOfWork, IPasswordHasher passwordHasher)
        {
            this._usersRepository = usersRepository;
            this._usersCustomerRepository = usersCustomerRepository;
            this._unitOfWork = unitOfWork;
            this._passwordHasher = passwordHasher;
        }

        public async Task<CreateUsersCustomerResponse> CreateUserAsync(UsersCustomer usersCustomer)
        {

            var existingUser = await _usersRepository.FindByEmailAsync(usersCustomer.User.Email);
            if (existingUser != null)
            {
                return new CreateUsersCustomerResponse(false, "Email already in use.", null, null);
            }

            usersCustomer.User.Username = usersCustomer.User.Email;
            usersCustomer.User.Password = _passwordHasher.HashPassword(usersCustomer.User.Password);
            usersCustomer.User.UserType = 1;
            usersCustomer.User.LastVisited = DateTime.Now;

            await _usersRepository.AddAsync(usersCustomer.User);
            int last_insert_id = usersCustomer.User.Id;
            usersCustomer.UserId = last_insert_id;

            await _usersCustomerRepository.AddAsync(usersCustomer);
            await _unitOfWork.CompleteAsync();

            return new CreateUsersCustomerResponse(true, null, usersCustomer.User, usersCustomer);

        }

    }
}
