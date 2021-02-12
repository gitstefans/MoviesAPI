using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using moviesAPI.Entities;

namespace moviesAPI.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(Guid movieId);
        bool MovieExists(Guid movieId);
        IEnumerable<Actor> GetActors(Guid movieId);
        Actor GetActor(Guid movieId, Guid actorId);
        
    }
}