using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services.Models
{
    public class UpdateTodoDto
    {
        [Required(ErrorMessage ="You must Enter The title")] //provide error message
        public string title { get; set; }


        public string description { get; set; }


        public DateTime create { get; set; }

        public DateTime due { get; set; }


        public TodoStatus ststus { get; set; }
    }
}
