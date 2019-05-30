using FreeWheelMovieAPI.Models.DTOs;
using FreeWheelMovieAPI.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeWheelMovieAPI.Models.Repository
{
    /// <summary>
    /// Interface to be implemented by the API controller for API's A,B,C & D
    /// </summary>
    public interface IMovieApiRepository
    {
        Task<List<Movie>> SearchMovies(MovieSearchFilters filter);
        Task<List<Movie>> GetUserAverageTopRatedMovies(int numberOfMovies);
        Task<List<Movie>> GetUserHighestRatedMovies(int userId, int noOfRatings);
        Task<int> UserMovieRatingsUpsert(UserMovieRating userMovieRating);

    }
}
