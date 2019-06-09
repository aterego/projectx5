using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace userServices.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        [Authorize(Roles = "Customer")]
        [Route("/api/protectedforcustomers")]
        public IActionResult GetProtectedData()
        {
            return Ok("Hello world from customer controller.");
        }

        [HttpGet]
        [Authorize(Roles = "Profi")]
        [Route("/api/protectedforprofi")]
        public IActionResult GetProtectedDataForProfi()
        {
            return Ok("Hello world from profi controller.");
        }
    }
}