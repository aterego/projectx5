﻿using DAL.Models;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UsersCustomerRepository :BaseRepository, IUsersCustomerRepository
    {
        public UsersCustomerRepository(MyDbContext context) : base(context)
        {
        }

        public async Task AddAsync(UsersCustomer usersCustomer)
        {
            await _context.UsersCustomer.AddAsync(usersCustomer);
            //await _context.SaveChangesAsync();
        }
    }
}
