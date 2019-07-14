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
    public class UserCategoriesService :IUserCategoriesService
    {
        private readonly IUserCategoriesRepository _userCategoriesRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserCategoriesService(IUserCategoriesRepository userCategoriesRepository,  IUnitOfWork unitOfWork)
        {
            this._userCategoriesRepository = userCategoriesRepository;
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<UserCategories>> GetCategoriesAsync(int userId)
        {
            return await _userCategoriesRepository.GetCategoriesAsync(userId);
        }

        public async Task<UserCategoriesResponse> SaveAsync(UserCategories userCategories)
        {
            try
            {
                await _userCategoriesRepository.AddAsync(userCategories);
                await _unitOfWork.CompleteAsync();

                return new UserCategoriesResponse(userCategories);
            }
            catch(Exception ex)
            {
                return new UserCategoriesResponse($"An error occurred when saving the categories: {ex.Message}");
            }
        }

        public async Task<UserCategoriesResponse> DeleteAsync(int userId)
        {
            var existingCategory = await _userCategoriesRepository.FindByUserIdAsync(userId);

            if (existingCategory == null)
                return new UserCategoriesResponse("Categories not found.");


            try
            {
                await _userCategoriesRepository.RemoveByUser(userId);
                await _unitOfWork.CompleteAsync();

                return new UserCategoriesResponse(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new UserCategoriesResponse($"An error occurred when deleting the category: {ex.Message}");
            }
        }

    }
}
