using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.Services.Models;
using TaskApi.Services.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorId}/mytodo")]
    [ApiController]
    public class MyTodoController : ControllerBase
    {
        private readonly ItodoRepository _TodoServices;
        private readonly IMapper _mapper;
        public MyTodoController(ItodoRepository repository , IMapper mapper)
        {
            _TodoServices = repository;
            _mapper = mapper;

        }

        //get all todos
        [HttpGet]
        public ActionResult<ICollection<TodoDto>> getTodo(int authorId)
        {
            var myTods = _TodoServices.allTodo(authorId);
            var mapedTodos = _mapper.Map<ICollection<TodoDto>>(myTods); //maped part
            return Ok(mapedTodos);
        }
        
        [HttpGet("{id}",Name ="GetTodo")]
        public IActionResult getOneTodo(int authorId , int id)
        {
            var todo = _TodoServices.gettodo(authorId,  id);

            if(todo is null)
            {
                return NotFound();
            }
            var mappedTodo = _mapper.Map<TodoDto>(todo); //from maped
            return Ok(mappedTodo);
        }

        [HttpPost]
        public ActionResult<TodoDto> CreateTodo(int authorId , CreateTodoDto todo)
        {

            var todoEntity = _mapper.Map<Todo>(todo);
            var newTodo = _TodoServices.AddTodo(authorId, todoEntity);
            var todoForReturn = _mapper.Map<TodoDto>(newTodo);

            return CreatedAtRoute("GetTodo", new { authorId = authorId, id = todoForReturn.id }, todoForReturn);
        }

        [HttpPut("{todoId}")]
        public ActionResult UpdateTodo(int authorId , int todoId ,UpdateTodoDto todo)
        {
            var updatingTodo = _TodoServices.gettodo(authorId, todoId);
            if(updatingTodo is null)
            {
                return NotFound();
            }
            _mapper.Map(todo, updatingTodo);
            _TodoServices.UpdateTodo(updatingTodo);

            return NoContent();
        }

        [HttpDelete("{todoId}")]
        public ActionResult DeleteTodo(int authorId , int todoId)
        {
            var deletingTodo = _TodoServices.gettodo(authorId, todoId);
            if (deletingTodo is null)
            {
                return NotFound();
            }

            _TodoServices.DeleteTodo(deletingTodo);
            return NoContent();
            
        }
    }
}
