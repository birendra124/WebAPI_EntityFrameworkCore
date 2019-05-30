using AutoMapper;
using FreeWheelMovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeWheelMovieAPI.Models.DTOs;

namespace FreeWheelMovieAPI.AutoMapper
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Mapping profile for mapping between model to dtos and vice versa
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Movie, MoviesDto>().ForMember(dest => dest.YearOfRelease, src => src.MapFrom(s => s.ReleaseYear));
            CreateMap<MoviesDto, Movie>();
            CreateMap<UserMovieRating, UserMovieRatingDto>();
            CreateMap<UserMovieRatingDto, UserMovieRating>();
            //CreateMap<User, UserDto>();
            //CreateMap<UserDto, User>();
        }
    }
}
