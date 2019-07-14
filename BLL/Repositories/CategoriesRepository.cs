using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using BLL.Helper;

namespace BLL.Repositories
{
    public class CategoriesRepository: BaseRepository, ICategoriesRespository
    {
        public CategoriesRepository(MyDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets List of All Categories.
        /// </summary>
        public async Task<IEnumerable<Categories>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        /// <summary>
        /// Get Category.
        /// </summary>
        /// <param name="id">Current category ID
        public async Task<Categories> GetCategoryAsync(int id)
        {
            return await _context.Categories.Where(s => s.Id == id).FirstAsync();
        }

        /// <summary>
        /// Gets List of All Categories with corresponding Prices.
        /// </summary>
        public async Task<IEnumerable<Categories>> ListWithPricesAsync()
        {
            return await _context.Categories.Include(c => c.CategoriesPrices).ToListAsync();
        }

        /// <summary>
        /// Get Category with corresponding Prices.
        /// </summary>
        /// <param name="id">Current category ID
        public async Task<Categories> GetCategoryWithPricesAsync(int id)
        {
            return await _context.Categories.Include(c => c.CategoriesPrices).Where(c => c.Id == id).FirstAsync();
        }

        public async Task<List<SelectListItem>> SelectListAsync()
        {
           return await  _context.Categories.Select(s =>
            new SelectListItem()
            {
                Value = s.Id.ToString(),
                Text = s.Name.ToString()
            }).ToListAsync();
        }

        public async Task AddAsync(Categories categories)
        {
            await _context.Categories.AddAsync(categories);
            await _context.SaveChangesAsync();
        }

        public async Task AddPricesAsync(CategoriesPrices categoriesPrices)
        {
           await _context.CategoriesPrices.AddAsync(categoriesPrices);
           await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Categories categories)
        {
            _context.Categories.Update(categories);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePricesAsync(CategoriesPrices categoriesPrices)
        {
            _context.CategoriesPrices.Update(categoriesPrices);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove category.
        /// </summary>
        /// <param name="category">Categories class
        public void Remove(Categories category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        /// <summary>
        /// Remove Prices.
        /// </summary>
        /// <param name="categoriesPrices">CategoriesPrices class
        public void Remove(CategoriesPrices categoriesPrices)
        {
            _context.CategoriesPrices.Remove(categoriesPrices);
            _context.SaveChanges();
        }

        /// <summary>
        /// Gets list of all child categories.
        /// </summary>
        /// <param name="id">Current category ID
        public async Task<IEnumerable<Categories>> GetChildCategoriesAsync(int id)
        {
            return await _context.Categories.Where(s => s.ParentId == id).ToListAsync();
        }

        /*
        /// <summary>
        /// Gets prices of category.
        /// </summary>
        /// <param name="id">Current category ID
        public async Task<IEnumerable<CategoriesPrices>> GetCategoryPricesAsync(int id)
        {
            return await _context.CategoriesPrices.Where(cp => cp.CategoryId == id).ToListAsync();
        }
        */

        /// <summary>
        /// Gets prices of category.
        /// </summary>
        /// <param name="id">Current category ID
        public async Task<CategoriesPrices> GetCategoryPricesAsync(int id)
        {
            return await _context.CategoriesPrices.Where(cp => cp.CategoryId == id).FirstOrDefaultAsync();
        }



        public List<CategoriesDN> GetDN()
        {
            var dn = (from c in _context.Categories
                      join cp in _context.CategoriesPrices on c.Id equals cp.CategoryId
                      select new 
                      {
                          c.Id,
                          c.ParentId,
                          c.Name,
                          c.Description,
                          cp.PriceMin,
                          cp.PriceMax
                      }).ToList();

            List<CategoriesDN> catDn = new List<CategoriesDN>();
            foreach(var d in dn)
            {
                catDn.Add(new CategoriesDN
                {
                    Id = d.Id,
                    ParentId = d.ParentId,
                    Name = d.Name,
                    Description = d.Description,
                    PriceMin = d.PriceMin,
                    PriceMax = d.PriceMax
                });
            }

           return catDn;
        }

    }
}
