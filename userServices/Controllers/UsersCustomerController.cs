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
    public class UsersCustomerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUsersCustomerService _usersCustomerService;

        public UsersCustomerController(IUsersCustomerService usersCustomerService, IMapper mapper)
        {
            _usersCustomerService = usersCustomerService;
            _mapper = mapper;
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateUsersCustomerAsync([FromBody] UsersCustomerResource usersCustomerResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
                        
            var user = _mapper.Map<UserCredentialsResource, Users>(usersCustomerResource.UserCredentials);
            usersCustomerResource.User = user;
            usersCustomerResource.User.LastIp = usersCustomerResource.LastIP;

            var usersCustomer = _mapper.Map<UsersCustomerResource, UsersCustomer>(usersCustomerResource);

            //var jsonSerializerSettings = new JsonSerializerSettings() { DateFormatHandling = DateFormatHandling.IsoDateFormat, DateParseHandling = DateParseHandling.DateTimeOffset, DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind };
            //var obj = JsonConvert.DeserializeObject(content, jsonSerializerSettings);
          

            var response = await _usersCustomerService.CreateUserAsync(usersCustomer);
            if (!response.Success)
            {
                return BadRequest(response.Message);
            }

            var userResource = _mapper.Map<Users, UsersResource>(response.User);
            return Ok(userResource);
        }
    }
}