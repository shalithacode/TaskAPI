using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;
namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private readonly IAuthorRepository _authorService;
        private readonly IMapper _mapper;

        public AuthorsController(IAuthorRepository authorRepository ,IMapper mapper)
        {
            _authorService = authorRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors([FromQuery]string job = "", [FromQuery] string search = "")
        {
            var authors = _authorService.GetAllAuthors(job, search);
            
            var authorsDto = _mapper.Map<ICollection<AuthorDto>>(authors);


            return Ok(authorsDto);
        }
        [HttpGet("{id}", Name = "GetAuthor")]
        public ActionResult<AuthorDto> GetAuthor(int id)
        {
            var author = _authorService.GetAuthor(id);
            var authorsDto = _mapper.Map<AuthorDto>(author);
            if (author is null) return NotFound();
            return Ok(authorsDto);
        }

        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor (CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var newAuthor = _authorService.AddAuthor(authorEntity);

            var authorDto = _mapper.Map<AuthorDto>(newAuthor);
            return CreatedAtRoute("GetAuthor", new {id = authorDto.Id} ,authorDto);
        }
    }
}
