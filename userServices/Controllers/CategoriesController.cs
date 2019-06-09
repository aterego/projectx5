using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using userServices.Services;
using userServices.Resources;
using AutoMapper;

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

        [HttpGet]
        public async Task<IEnumerable<CategoriesResource>> GetAllAsync()
        {
            var categories = await _categoriesService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Categories>, IEnumerable<CategoriesResource>>(categories);

            return resources;
        }



    }
}