using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using moviesAPI.Models;
using moviesAPI.Repositories;

namespace moviesAPI.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieController(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository ?? throw new ArgumentNullException(nameof(movieRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet()]
        public ActionResult<IEnumerable<MovieDTO>> GetMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return Ok(_mapper.Map<IEnumerable<MovieDTO>>(movies));
        }
        // forward slash is added automatically 
        [HttpGet("{movieId}")]
        public IActionResult GetMovie(Guid movieId)
        {
            
            var movie = _movieRepository.GetMovieById(movieId);
            
            if(movie == null)
            {
                return NotFound();
            }
            var actors = _movieRepository.GetActors(movieId);
            movie.Actors = actors.ToList();
            // foreach(var actor in actors)
            // {
            //     movie.Actors.Add(actor);
            // }
            
            //return Ok(_mapper.Map<MovieDTO>(movie));    
            return Ok(movie);  
        }
    }
}