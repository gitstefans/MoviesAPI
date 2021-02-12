using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using moviesAPI.Data;
using moviesAPI.Entities;

namespace moviesAPI.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _movieContext;

        public MovieRepository(MovieContext movieContext)
        {
            _movieContext = movieContext ?? throw new ArgumentNullException(nameof(movieContext));
        }

        public IEnumerable<Movie> GetAllMovies()
        {   
            return _movieContext.Movies.ToList<Movie>();
        }

        public Movie GetMovieById(Guid movieId)
        {
            if(movieId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(movieId));
            }

            return _movieContext.Movies.FirstOrDefault(m => m.MovieId == movieId);
        }

        public bool MovieExists(Guid movieId)
        {
            if(movieId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(movieId));
            }

            return _movieContext.Movies.Any(m => m.MovieId == movieId);
        }

        public IEnumerable<Actor> GetActors(Guid movieId)
        {
            if(movieId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(movieId));
            }

            return _movieContext.Actors.Where(a => a.MovieId == movieId).ToList();
        }

        public Actor GetActor(Guid movieId, Guid actorId)
        {
            if(movieId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(movieId));
            }

            if(actorId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(actorId));
            }

            return _movieContext.Actors.Where(a => a.MovieId == movieId && a.ActorId == actorId).FirstOrDefault();
        }
    }
}