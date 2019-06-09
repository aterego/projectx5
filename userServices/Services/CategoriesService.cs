using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using BLL.Repositories;

namespace userServices.Services
{
    public class CategoriesService :ICategoriesService
    {
        private readonly ICategoriesRespository _categoriesRepository;

        public CategoriesService(ICategoriesRespository categoriesRespository)
        {
            this._categoriesRepository = categoriesRespository;
        }
            
        public async Task<IEnumerable<Categories>> ListAsync()
        {
            return await _categoriesRepository.ListAsync();
        }

    }
}
