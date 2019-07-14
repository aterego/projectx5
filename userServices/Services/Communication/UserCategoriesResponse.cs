using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userServices.Services.Communication
{
    public class UserCategoriesResponse :BaseResponse
    {
        public UserCategories UserCategories { get; private set; }

        private UserCategoriesResponse(bool success, string message, UserCategories userCategories) : base(success, message)
        {
            UserCategories = userCategories;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public UserCategoriesResponse(UserCategories userCategories) : this(true, string.Empty, userCategories)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public UserCategoriesResponse(string message) : this(false, message, null)
        { }
    }
}
