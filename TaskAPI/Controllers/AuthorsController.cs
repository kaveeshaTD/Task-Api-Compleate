using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.Services.Authors;
using TaskApi.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _Authorservices;
        private readonly IMapper _mapper; //for auto mapper
        

        //constructor
        public AuthorsController(IAuthorRepository services , IMapper mapper)
        {
            _Authorservices = services;
            _mapper = mapper; //for auto mapper
        }

        //to get all author
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> getAllAuthors(string job , string search)
        {
            

            var authors = _Authorservices.getAllAuthors(job , search); // comming from services layer
            var mapedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
            return Ok(mapedAuthors);
        }

        //to get on author
        [HttpGet("{id}",Name ="GetAuthor")] //name=="get author new add "
        public IActionResult getAuthot(int id)
        {
            var author = _Authorservices.getAuthor(id); // comming from services layer
            
            if(author is null)
            {
                return NotFound(); //no author from that id
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);
            return Ok(mappedAuthor);
        }

        //to create author
        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author); //author get from models namespace
            var newAuthor = _Authorservices.AddAuthor(authorEntity);

            var authorForReturn = _mapper.Map<AuthorDto>(newAuthor);

            return CreatedAtRoute("GetAuthor", new { id = authorForReturn.id }, authorForReturn);

        }
    }
}
