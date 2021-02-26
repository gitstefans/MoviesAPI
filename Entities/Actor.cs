using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace moviesAPI.Entities
{
    public class Actor
    {
        [Key]
        public Guid ActorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [ForeignKey("MovieId")]
        public Guid MovieId { get; set; }

    }
}