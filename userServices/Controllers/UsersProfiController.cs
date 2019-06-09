using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using userServices.Services;
using userServices.Resources;
using DAL.Models;
using System;
using Newtonsoft.Json;

namespace userServices.Controllers
{
    [Route("/api/[controller]")]
    public class UsersProfiController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUsersProfiService _usersProfiService;

        public UsersProfiController(IUsersProfiService usersProfiService, IMapper mapper)
        {
            _usersProfiService = usersProfiService;
            _mapper = mapper;
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateUsersProfiAsync([FromBody] UsersProfiResource usersProfiResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
                        
            var user = _mapper.Map<UserCredentialsResource, Users>(usersProfiResource.UserCredentials);
            usersProfiResource.User = user;
            usersProfiResource.User.LastIp = usersProfiResource.LastIP;

            var usersProfi = _mapper.Map<UsersProfiResource, UsersProfi>(usersProfiResource);

            //var jsonSerializerSettings = new JsonSerializerSettings() { DateFormatHandling = DateFormatHandling.IsoDateFormat, DateParseHandling = DateParseHandling.DateTimeOffset, DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind };
            //var obj = JsonConvert.DeserializeObject(content, jsonSerializerSettings);
          

            var response = await _usersProfiService.CreateUserAsync(usersProfi);
            if (!response.Success)
            {
                return BadRequest(response.Message);
            }

            var userResource = _mapper.Map<Users, UsersResource>(response.User);
            return Ok(userResource);
        }
    }
}