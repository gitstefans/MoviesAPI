using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using moviesAPI.Entities;

namespace moviesAPI.Models
{
    public class MovieDTO
    {
        public Guid MovieId;
        public string Name { get; set; }      
        public string ImageUrl { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public ICollection<ActorDTO> Actors { get; set; } 
            = new List<ActorDTO>();
    }
}