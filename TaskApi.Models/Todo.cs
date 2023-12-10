using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi.Models
{
   public class Todo
    {
        public int id { get; set; }
        [Required]
        [MaxLength(200)]
        public string title { get; set; }

        [MaxLength(300)]
        public string description { get; set; }

        [Required]
        public DateTime create { get; set; }

        [Required]
        public DateTime due { get; set; }

        [Required]
        public TodoStatus ststus { get; set; }

        //from author class
        public int Authorid { get; set; }
        public Author Author { get; set; }
    }
}
