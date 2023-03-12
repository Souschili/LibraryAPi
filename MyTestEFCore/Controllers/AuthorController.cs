using Microsoft.AspNetCore.Mvc;
using MyTestEFCore.DAL.Context;

namespace MyTestEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AuthorController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Author")]
        public async Task<IActionResult> AddAuthorAsync(string name)
        {
            await _context.Authors.AddAsync(
                new DAL.Entitys.Author { FullName = name, BirthDay = DateTime.Parse("01.01.2020") }
            );
            _context.SaveChanges();
            return Ok();
        }
    }
}
