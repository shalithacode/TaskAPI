using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        private readonly ITodoRepository _todoService;

        public TodosController(ITodoRepository todoRepository)
        {
            _todoService = todoRepository;

        }

        [HttpGet()]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos() ;

            if (id is null) return Ok(myTodos);
            else return Ok(myTodos.Where(todo => todo.Id == id));
  
        }
        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _todoService.GetTodo(id);
            if (todo is null) return NotFound();
            return Ok(todo);

        }


    }
}
