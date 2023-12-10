using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi.Models
{
   public class Author
    {
        public int id { get; set; }

        [Required] //data anonation
        [MaxLength(250)]
        public string FullName { get; set; }
        [MaxLength(20)]
        public string AddrssNo { get; set; }

        [MaxLength(200)]
        public string street { get; set; }

        [Required]
        [MaxLength(100)]
        public string city { get; set; }

        [Required]
        [MaxLength(30)]
        public string jobRole { get; set; }

        public ICollection<Todo> todos { get; set; } = new List<Todo>();

    }
}
