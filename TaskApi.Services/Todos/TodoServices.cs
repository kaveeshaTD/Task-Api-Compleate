using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services.Todos
{
    public class TodoServices : ItodoRepository
    {

        public List<Todo> allTodo(int authorId)
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                id = 1,
                title = "Gets book new",
                description = "Get books fro the School new",
                create =  DateTime.Now,
                due = DateTime.Now.AddDays(5),
                ststus = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo 
            {
                id = 2,
                title = "Get car parts new",
                description = "Get spare arts for vehichel new",
                create = DateTime.Now,
                due = DateTime.Now.AddDays(4),
                ststus = TodoStatus.New
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                id = 3,
                title = "Get Food New",
                description = "Get foods for the week new",
                create = DateTime.Now,
                due = DateTime.Now.AddDays(3),
                ststus = TodoStatus.New
            };
            todos.Add(todo3);

            var todo4 = new Todo
            {
                id = 4,
                title = "Get Medicine new",
                description = "Get medicine Hosptiale new",
                create = DateTime.Now,
                due = DateTime.Now.AddDays(1),
                ststus = TodoStatus.New
            };
            todos.Add(todo4);

            return todos;

        }

        public Todo gettodo(int authorId , int id)
        {
            throw new NotImplementedException();
        }

        public Todo AddTodo(int authorId, Todo todo)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
