using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using userServices.Services;
using userServices.Resources;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace userServices.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService _categoriesService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoriesService categoriesService, IMapper mapper)
        {
            _categoriesService = categoriesService;
            _mapper = mapper;
        }

        [Route("/api/categories/all")]
        [HttpGet]
        //***AVA*** unnecessary get without/with prices
        public async Task<IEnumerable<CategoriesResource>> GetAllAsync()
        {
            var categories = await _categoriesService.ListAsync();
           
            //***AVA*** here comes prices
            
            foreach(var cat in categories)
            {
                var catPrices = await _categoriesService.GetCategoryPricesAsync(cat.Id);
                var catPricesResource = _mapper.Map<CategoriesPrices, CategoriesPricesResource>(catPrices);
            }
            

            var resources = _mapper.Map<IEnumerable<Categories>, IEnumerable<CategoriesResource>>(categories);

            return resources;
        }

        [Authorize]
        [Route("/api/categories/allwprices")]
        [HttpGet]
        public async Task<IEnumerable<CategoriesResource>> GetAllWithPricesAsync()
        {
            var categories = await _categoriesService.ListWithPricesAsync();
            var resources = _mapper.Map<IEnumerable<Categories>, IEnumerable<CategoriesResource>>(categories);

            return resources;
        }
        



    }
}