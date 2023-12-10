using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> getAllAuthors();

        public List<Author> getAllAuthors(string job , string search);

        //user authot select only one author no need list
        public Author getAuthor(int id);
        public Author AddAuthor(Author author); //from service method  add method
    }
}
