using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface IUsersCustomerRepository
    {
        Task AddAsync(UsersCustomer usersCustomer);
    }
}
