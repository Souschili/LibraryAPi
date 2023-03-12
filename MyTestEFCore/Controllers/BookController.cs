using Microsoft.AspNetCore.Mvc;
using MyTestEFCore.DAL.Context;
using MyTestEFCore.DAL.Entitys;

namespace MyTestEFCore.Controllers
{
    public class BookDTO
    {
        public string? BookName { get; set; }
        public int Pages { get; set; }
        public int AuthorId { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BookController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddBook (BookDTO book)
        {
            var author=_dbContext.Authors.FirstOrDefault(x=>x .Id==book.AuthorId);

            var obj = new Book
            {
                BookName=book.BookName,
                Pages=book.Pages,
                Author=author
            };
            await _dbContext.AddAsync(obj);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
