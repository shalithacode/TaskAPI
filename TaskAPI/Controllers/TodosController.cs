using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Todos;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository todoRepository, IMapper mapper)
        {
            _todoService = todoRepository;
            _mapper = mapper;

        }

        [HttpGet()]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)
        {
            var myTodos = _todoService.AllTodos(authorId) ;

            var myTodosDto = _mapper.Map<ICollection<TodoDto>>(myTodos);

            return Ok(myTodosDto);
  
        }
        [HttpGet("{id}")]
        public ActionResult<AuthorDto> GetTodo(int authorId, int id)
        {
            var todo = _todoService.GetTodo(authorId, id);
            var myTodoDto = _mapper.Map<TodoDto>(todo);
            if (todo is null) return NotFound();
            return Ok(myTodoDto);

        }


    }
}
