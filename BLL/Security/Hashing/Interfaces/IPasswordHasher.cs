using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Security
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        bool PasswordMatches(string providedPassword, string passwordHash);
    }
}
