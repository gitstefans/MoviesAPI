using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using moviesAPI.Repositories;

namespace moviesAPI.Controllers
{
    [ApiController]
    [Route("api/movies/{movieId}/actors")]
    public class ActorsController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public ActorsController(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository ?? throw new ArgumentNullException(nameof(movieRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}