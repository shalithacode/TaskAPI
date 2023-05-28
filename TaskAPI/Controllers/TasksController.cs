using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var tasks = new string[] { "Task 1", "Task 2", "Task 3" };
            return Ok(tasks);
        }
        [HttpPost]
        public IActionResult NewTasks()
        { 
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTasks()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTasks()
        {
            return BadRequest();
        }
    }
}
