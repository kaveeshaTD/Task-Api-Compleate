using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services.Todos
{
    public interface ItodoRepository
    {
        public List<Todo> allTodo(int authorId); //to get select author todo
        public Todo gettodo(int authorId , int id);

        public Todo AddTodo(int authorId, Todo todo);
        public void UpdateTodo(Todo todo);
        public void DeleteTodo(Todo todo);
    }
}
