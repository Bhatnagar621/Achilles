using Microsoft.AspNetCore.Mvc;
using PersonService.Core.Commands;

namespace PersonService.API.Controllers
{
    [ApiController]
    [Route("/api/person")]
    public class CommandController : Controller
    {
        [HttpPost("signup")]
        public IActionResult SignUp(SignUpCommand request)
        {
            return Ok();
        }
    }
}
