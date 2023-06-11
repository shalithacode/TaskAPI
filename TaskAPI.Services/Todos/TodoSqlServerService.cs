using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;


namespace TaskAPI.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {

        private readonly TodoDBContext _dbContext = new TodoDBContext();
        public List<Todo> AllTodos(int authorId)
        {
            return _dbContext.Todos.Where(t => t.AuthorId==authorId).ToList();
        }

        public Todo GetTodo(int authorId, int id)
        {
            return _dbContext.Todos.FirstOrDefault(t => t.AuthorId == authorId && t.Id == id);
        }
    } 
}
