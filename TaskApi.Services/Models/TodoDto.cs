using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi.Services.Models
{
    public class TodoDto
    {
        public int id { get; set; }

        public string title { get; set; }


        public string description { get; set; }


        public DateTime create { get; set; }


        public DateTime due { get; set; }


        public string ststus { get; set; } // new , inprogreas,compleate

        //from author class
        public int Authorid { get; set; }
    }  
}
