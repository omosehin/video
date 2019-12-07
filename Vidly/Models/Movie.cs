using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    //This class is a plain old C-L or object or POKO which represents the state and behaviour of our application in terms of it problem domain
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}