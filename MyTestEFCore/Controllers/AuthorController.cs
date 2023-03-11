using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyTestEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        public AuthorController() { }

        [HttpPost("Author")]
        public IActionResult AddAuthor(string name)
        {
            return Ok();
        }
    }
}
