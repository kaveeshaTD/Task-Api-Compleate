using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.Services.Models;

namespace TaskApi.Services.Profiles
{
    public class TodoProfile : Profile
    {
        public TodoProfile()
        {
            CreateMap<Todo, TodoDto>();
            CreateMap<CreateTodoDto, Todo>(); //create map for createtod
            CreateMap<UpdateTodoDto, Todo>();//create map for update todo
                
        }
    }
}
