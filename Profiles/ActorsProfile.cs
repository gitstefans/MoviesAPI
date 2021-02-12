using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace moviesAPI.Profiles
{
    public class ActorsProfile : Profile
    {
        public ActorsProfile()
        {
            CreateMap<Entities.Actor, Models.ActorDTO>();
        }
    }
}