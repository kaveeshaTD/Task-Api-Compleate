using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi.Services.Models
{
    public class AuthorDto
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Addrss { get; set; }
        public string jobRole { get; set; }
    }
}
