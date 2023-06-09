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
        public List<Todo> AllTodos()
        {
            return _dbContext.Todos.ToList();
        }

        public Todo GetTodo(int id)
        {
            return _dbContext.Todos.Find(id);
        }
    }
}
