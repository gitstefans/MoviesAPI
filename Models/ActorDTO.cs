using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using moviesAPI.Entities;

namespace moviesAPI.Models
{
    public class ActorDTO
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Guid MovieId { get; set; }
    }
}