using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Repositories
{
    public interface IUsersRepository
    {
        /// <summary>
        /// Gets Admins under roles.
        /// </summary>
        /// <param name="roleId">Current role ID
        //Task<IEnumerable<Users>> ListAsync(int roleId);
        /// <summary>
        /// Get Users.
        /// </summary>
        /// <param name="id">Current user ID
        Task AddAsync(Users users);
        //Task<bool> UsersExists(int id);

        Task<Users> FindByEmailAsync(string email);
    }
}
