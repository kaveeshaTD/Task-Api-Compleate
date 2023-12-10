using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.DataAcses;

namespace TaskApi.Services.Authors
{
    public class AuthorSqlServices : IAuthorRepository
    {
        private readonly TodoDbcontext _context = new TodoDbcontext();
        public List<Author> getAllAuthors()
        {
            return _context.Authors.ToList();  //authors comming from DBset<> authors
        }

        //to filter or return all authors
        public List<Author> getAllAuthors(string job , string search)
        {
            if (string.IsNullOrWhiteSpace(job) && string.IsNullOrWhiteSpace(search))
            {
                return getAllAuthors();
            }

            var authorCollection = _context.Authors as IQueryable<Author>;
            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim(); //remove the space
                authorCollection = authorCollection.Where(a => a.jobRole == job);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(a => a.FullName.Contains(search) || a.city.Contains(search));
            }


            // return _context.Authors.Where(a => a.jobRole == job).ToList(); previous
            return authorCollection.ToList();
        }
        public Author getAuthor(int id)
        {
            return _context.Authors.Find(id);
        }


        //create author
        public Author AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();

            return _context.Authors.Find(author.id);
        }
    }
}
