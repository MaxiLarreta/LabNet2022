using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class RickAndMortyModel
    {
        public string Name { get; set; }
        public string Species { get; set; } 
        public string Gender { get; set; }
        public string Origin { get; set; }  
        public string Image { get; set; }
    }
}