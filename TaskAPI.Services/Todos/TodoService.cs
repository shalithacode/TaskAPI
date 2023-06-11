using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos(int authorId)
        {
            var todos = new List<Todo>();
            var todo1 = new Todo()
            {
                Id = 1,
                Title = "Buy Book",
                Description = "Buy boo for school.",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            };
            todos.Add(todo1);
            var todo2 = new Todo()
            {
                Id = 2,
                Title = "Read book",
                Description = "study for exam.",
                Created = DateTime.Now,
                Due = DateTime.Now.AddHours(2),
                Status = TodoStatus.New
            };
            todos.Add(todo2);
            var todo3 = new Todo()
            {
                Id = 3,
                Title = "Eat",
                Description = "Eat lunch meal",
                Created = DateTime.Now,
                Due = DateTime.Now.AddHours(5),
                Status = TodoStatus.Completed
            };
            todos.Add(todo3);
            return todos;
        }

 
        public Todo GetTodo(int authorId, int id)
        {
            throw new NotImplementedException();
        }
    }
}
