using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;

namespace userServices.Services
{
    public interface ICategoriesService
    {
        Task<IEnumerable<Categories>> ListAsync();
        Task<IEnumerable<Categories>> ListWithPricesAsync();
        //Task<IEnumerable<CategoriesPrices>> GetCategoryPricesAsync(int id);
        Task<CategoriesPrices> GetCategoryPricesAsync(int id);
    }
}
