using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoRepository _todoService;

        public TodosController(ITodoRepository todoRepository)
        {
            _todoService = todoRepository;

        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos() ;

            if (id is null) return Ok(myTodos);
            else return Ok(myTodos.Where(todo => todo.Id == id));
  
        }
        
     

    }
}
