using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi.Services.Models
{
    public class CreateAuthorDto
    {
        public string FullName { get; set; }
      
        public string AddrssNo { get; set; }

      
        public string street { get; set; }

       
        public string city { get; set; }

       
        public string jobRole { get; set; }
        public ICollection<CreateTodoDto> todos { get; set; } = new List<CreateTodoDto>();

      
    }
}
