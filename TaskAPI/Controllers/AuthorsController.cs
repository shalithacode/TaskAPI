using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;
namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private readonly IAuthorRepository _authorService;

        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorService = authorRepository;
        }
        [HttpGet()]
        public IActionResult GetAuthors()
        {

            return Ok(_authorService.GetAllAuthors());
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorService.GetAuthor(id);
            if (author is null) return NotFound();
            return Ok(author);
        }
    }
}
