using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace moviesAPI.Entities
{
    public class Movie
    {
        [Key]
        public Guid MovieId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int Year { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public string Genre { get; set; }
        [Required]
        public ICollection<Actor> Actors { get; set; }
            = new List<Actor>();
        
        
    }
}