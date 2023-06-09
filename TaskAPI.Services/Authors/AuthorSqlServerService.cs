using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.DataAccess;
using TaskAPI.Models;


namespace TaskAPI.Services.Authors

{
    public class AuthorSqlServerService : IAuthorRepository
    {

        private readonly TodoDBContext _dbContext = new TodoDBContext();
        public List<Author> GetAllAuthors()
        {
            return _dbContext.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _dbContext.Authors.Find(id);
        }
    }
}
