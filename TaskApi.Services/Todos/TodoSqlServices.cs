using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.DataAcses;

namespace TaskApi.Services.Todos
{
    public class TodoSqlServices : ItodoRepository
    {
        private readonly TodoDbcontext _context = new TodoDbcontext();
        public List<Todo> allTodo(int authorId)
        {
            return _context.Todos.Where(t => t.Authorid == authorId).ToList();
        }

        public Todo gettodo(int authorId , int id)
        {
            return _context.Todos.FirstOrDefault(t => t.id == id && t.Authorid==authorId);
        }

        //create todo
        public Todo AddTodo(int authorId , Todo todo)
        {
            todo.Authorid = authorId;
            _context.Todos.Add(todo);
            _context.SaveChanges();

            return _context.Todos.Find(todo.id);
        }

        //update todo
        public void UpdateTodo(Todo todo)
        {
            _context.SaveChanges();
        }

        //delete Todo
        public void DeleteTodo(Todo todo)
        {
            _context.Remove(todo);
            _context.SaveChanges();
        }
    }
}
