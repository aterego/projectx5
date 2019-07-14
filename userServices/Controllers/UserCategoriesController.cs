using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using userServices.Services;
using userServices.Resources;
using DAL.Models;
using System;
using Newtonsoft.Json;
using userServices.Extensions;

namespace userServices.Controllers
{
    [Route("/api/[controller]")]
    public class UserCategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserCategoriesService _userCategoriesService;

        public UserCategoriesController(IUserCategoriesService userCategoriesService, IMapper mapper)
        {
            _userCategoriesService = userCategoriesService;
            _mapper = mapper;
        }

        //***AVA*** save array
        /*
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] List<UserCategoriesResource> userCategoriesResource)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            foreach (var ucr in userCategoriesResource)
            {
                var userCategories = _mapper.Map<UserCategoriesResource, UserCategories>(ucr);
                var result = await _userCategoriesService.SaveAsync(userCategories);
                if (!result.Success)
                    return BadRequest(result.Message);
            }

            var res = new UserCategories { UserId = 0, CategoryId = 0 };

            var userCatResource = _mapper.Map<UserCategories, UserCategoriesResource>(res);
            return Ok(userCatResource);

        }
        */

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserCategoriesResource userCategoriesResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var userCategories = _mapper.Map<UserCategoriesResource, UserCategories>(userCategoriesResource);
            var result = await _userCategoriesService.SaveAsync(userCategories);

            if (!result.Success)
                return BadRequest(result.Message);

            var userCatResource = _mapper.Map<UserCategories, UserCategoriesResource>(result.UserCategories);
            return Ok(userCatResource);

        }


        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteAsync(int userId)
        {
            var result = await _userCategoriesService.DeleteAsync(userId);

            if (!result.Success)
                return BadRequest(result.Message);

            var userCatResource = _mapper.Map<UserCategories, UserCategoriesResource>(result.UserCategories);
            return Ok(userCatResource);
        }

    }
}