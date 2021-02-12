using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace moviesAPI.Profiles
{
    public class MoviesProfile : Profile
    {
        public MoviesProfile()
        {
            // source, destination
            CreateMap<Entities.Movie, Models.MovieDTO>().PreserveReferences();
            CreateMap<Models.MovieDTO, Entities.Movie>().PreserveReferences();
            
        }
    }
}