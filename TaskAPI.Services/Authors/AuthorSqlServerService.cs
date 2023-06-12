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
        public List<Author> GetAllAuthors(string job, string search)
        {
            if (string.IsNullOrWhiteSpace(job) && string.IsNullOrWhiteSpace(search))
            {
                return GetAllAuthors();
            }

            var authorsCollection = _dbContext.Authors as IQueryable<Author>;

            if (!string.IsNullOrWhiteSpace(job))
            {
            job = job.Trim();
                authorsCollection = authorsCollection.Where(author => author.JobRole == job);
            }
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorsCollection = authorsCollection.Where(author => author.Name.Contains(search));
            }
            return authorsCollection.ToList();
        }

    }
}
