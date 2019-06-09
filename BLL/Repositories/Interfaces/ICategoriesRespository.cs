using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using BLL.Helper;

namespace BLL.Repositories
{
    public interface ICategoriesRespository
    {
        /// <summary>
        /// List all Categories.
        /// </summary>
        Task<IEnumerable<Categories>> ListAsync();
        /// <summary>
        /// Get Category.
        /// </summary>
        /// <param name="id">Current category ID
        Task<Categories> GetCategoryAsync(int id);
        /// <summary>
        /// Gets List of All Categories with corresponding Prices.
        /// </summary>
        Task<IEnumerable<Categories>> ListWithPricesAsync();
        /// <summary>
        /// Get Category with corresponding Prices.
        /// </summary>
        /// <param name="id">Current category ID
        Task<Categories> GetCategoryWithPricesAsync(int id);

        Task<List<SelectListItem>> SelectListAsync();
        /// <summary>
        /// Add new Category in database.
        /// </summary>
        Task AddAsync(Categories categories);
        /// <summary>
        /// Add new Category prices in database.
        /// </summary>
        Task AddPricesAsync(CategoriesPrices categoriesPrices);
        Task UpdateAsync(Categories categories);
        Task UpdatePricesAsync(CategoriesPrices categoriesPrices);
        /// <summary>
        /// Remove category.
        /// </summary>
        /// <param name="id">Current category ID
        void Remove(Categories category);
        /// <summary>
        /// Remove Prices.
        /// </summary>
        /// <param name="categoriesPrices">CategoriesPrices class
        void Remove(CategoriesPrices categoriesPrices);
        /// <summary>
        /// Gets list of all child categories.
        /// </summary>
        /// <param name="id">Current category ID
        Task<IEnumerable<Categories>> GetChildCategoriesAsync(int id);
        /// <summary>
        /// Gets prices of category.
        /// </summary>
        /// <param name="id">Current category ID
        Task<IEnumerable<CategoriesPrices>> GetCategoryPricesAsync(int id);
        List<CategoriesDN> GetDN();
    }
}
