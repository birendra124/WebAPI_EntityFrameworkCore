using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FreeWheelMovieAPI.Models.Filters;
using Newtonsoft.Json;
using FreeWheelMovieAPI.Models.DTOs;
using FreeWheelMovieAPI.Models.Repository;
using FreeWheelMovieAPI.Models;
using AutoMapper;
using FreeWheelMovieAPI.Shared;

namespace FreeWheelMovieAPI.Controllers
{
    /// <summary>
    /// This is main controller to be used for accessing the 4 APIs
    /// </summary>
    [Produces("application/json")]
    [Route("FreeWheelMovieApi/v1/[controller]")]
    [ApiController]
    public class MoviesStoreController : ControllerBase
    {

        #region "APIs A, B, C D Implementations"
        /// <summary>
        /// API : A
        /// </summary>
        /// <param name="filter">Filter to be applied on search for movies</param>
        /// <returns>List of movie details matching filter criteria in json format</returns>
        [Route("~/FreeWheelMovieApi/v1/SearchMovies")]
        [HttpPost]
        public async Task<IActionResult> SearchMovies([FromBody] MovieSearchFilters filter)
        {
            try
            {
                _logger.LogInformation("Information is logged, In SearchMovies() API call with filter=" + JsonConvert.SerializeObject(filter));
                if (filter == null ||
                    ((filter.generes == null || filter.generes.Count <= 0) &&
                      string.IsNullOrEmpty(filter.title) && filter.yearOfRelease <= 0))
                    return BadRequest("No search criteria given"); // Returns HttpStatusCode = 400

                var movies = await _movieApiRepository.SearchMovies(filter);
                var movieDtos = _mapper.Map<List<MoviesDto>>(movies);
                foreach (MoviesDto moviesDto in movieDtos)
                    moviesDto.Generes = string.Join(", ", _genreDataRepository.GetGenres(moviesDto.Id)?.Select(x => x.Name));
                if (movieDtos != null && movieDtos.Any())
                    return Ok(movieDtos); // Returns HttpStatusCode = 200
                else
                    return NotFound("No movie found based on the criteria");  // Returns HttpStatusCode = 404
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occured in SearchMovies() API call." + "\n" + ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
                throw ex;
            }
        }

        /// <summary>
        /// API : B
        /// </summary>
        /// <param name="numberOfMovies">Total number of movies</param>
        /// <returns>List of movie details in json format</returns>
        [Route("~/FreeWheelMovieApi/v1/GetUserAverageTopRatedMovies/{numberOfMovies}")]
        [HttpGet]
        public async Task<IActionResult> GetUserAverageTopRatedMovies(int numberOfMovies)
        {
            try
            {
                _logger.LogInformation("Information is logged, In GetUserAverageTopRatedMovies() API call with parameter numberOfMovies=" + numberOfMovies);

                if (numberOfMovies <= 0)
                    return BadRequest("Please provide some non zero number for fetching the total user average rated movies"); // Returns HttpStatusCode = 400

                var movies = await _movieApiRepository.GetUserAverageTopRatedMovies(numberOfMovies);
                var movieDtos = _mapper.Map<List<MoviesDto>>(movies);
                foreach (MoviesDto moviesDto in movieDtos)
                    moviesDto.Generes = string.Join(", ", _genreDataRepository.GetGenres(moviesDto.Id)?.Select(x => x.Name));
                if (movieDtos != null && movieDtos.Any())
                    return Ok(movieDtos); // Returns HttpStatusCode = 200
                else
                    return NotFound("No movie found based on the criteria");  // Returns HttpStatusCode = 404

            }
            catch (Exception ex)
            {
                _logger.LogError("Error occured in GetUserAverageTopRatedMovies() API call." + "\n" + ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
                throw ex;
            }
        }

        /// <summary>
        /// API: C
        /// </summary>
        /// <param name="userId">Userid whose  highest rating we need to fetch</param>
        /// <returns>List of movie details in json format</returns>
        [Route("~/FreeWheelMovieApi/v1/GetUserHighestRatedMovies/{userId}")]
        [HttpGet]
        public async Task<IActionResult> GetUserHighestRatedMovies(int userId)
        {
            try
            {
                _logger.LogInformation("Information is logged, In GetUserHighestRatedMovies() API call with parameter userId=" + userId);
                const int NoOfRatings = 5;
                if (userId <= 0)
                    return BadRequest("Please provide valid userId for fetching the user's highest rated movies"); // Returns HttpStatusCode = 400

                var movies = await _movieApiRepository.GetUserHighestRatedMovies(userId, NoOfRatings);
                var movieDtos = _mapper.Map<List<MoviesDto>>(movies);
                foreach (MoviesDto moviesDto in movieDtos)
                    moviesDto.Generes = string.Join(", ", _genreDataRepository.GetGenres(moviesDto.Id)?.Select(x => x.Name));
                if (movieDtos != null && movieDtos.Any())
                    return Ok(movieDtos); // Returns HttpStatusCode = 200
                else
                    return NotFound("No movie found based on the criteria");  // Returns HttpStatusCode = 404
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occured in GetUserHighestRatedMovies() API call." + "\n" + ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
                throw ex;
            }
        }

        /// <summary>
        /// API : D
        /// </summary>
        /// <param name="userMovieRatingDto">USer vs Movie rating to be saved</param>
        /// <returns>Status code of update operation</returns>
        [Route("~/FreeWheelMovieApi/v1/UpdateUserMovieRating")]
        [HttpPost]
        public async Task<IActionResult> UpdateUserMovieRating(UserMovieRatingDto userMovieRatingDto)
        {
            try
            {
                _logger.LogInformation("Information is logged, In UpdateUserMovieRating() API call with parameter userMovieRatingDto=" + JsonConvert.SerializeObject(userMovieRatingDto));
                if (userMovieRatingDto.RatingStars < 1 || userMovieRatingDto.RatingStars > 5)
                    return BadRequest("Invalid rating stars value provided by user for movie");

                if (_movieDataRepository.Get(userMovieRatingDto.MovieId) == null)
                    return NotFound("Movie not found");

                if (_userDataRepository.Get(userMovieRatingDto.UserId) == null)
                    return NotFound("User not found");

                var userMovieRating = _mapper.Map<UserMovieRating>(userMovieRatingDto);

                int userMovieRatingId = await _movieApiRepository.UserMovieRatingsUpsert(userMovieRating);
                if (userMovieRatingId > 0)
                    return Ok("Succesfully updated user's movie ratingstar record, resultCode=" + userMovieRatingId);
                else
                    if (userMovieRatingId == 0)
                    return Ok("Succesfully inserted or added new user's movie ratingstar record, resultCode=" + userMovieRatingId);
                else
                    return StatusCode(500);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occured in UpdateUserMovieRating() API call." + "\n" + ex.Message + "\n" + ex.StackTrace + "\n" + ex.InnerException);
                throw ex;
            }
        }

        #endregion

        #region "Private members"
        private readonly IMovieApiRepository _movieApiRepository;
        private readonly IDataRepository<Movie> _movieDataRepository;
        private readonly IDataRepository<User> _userDataRepository;
        private readonly IGenreDataRepository _genreDataRepository;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        #endregion

        #region "Constructor with dependecy injections"
        public MoviesStoreController(IMovieApiRepository movieApiRepository,
                                     IDataRepository<Movie> movieDataRepository,
                                     IDataRepository<User> userDataRepository,
                                     IGenreDataRepository genreDataRepository,
                                     IMapper mapper,
                                     ILoggerManager logger)
        {
            _movieApiRepository = movieApiRepository;
            _movieDataRepository = movieDataRepository;
            _userDataRepository = userDataRepository;
            _genreDataRepository = genreDataRepository;
            _mapper = mapper;
            _logger = logger;
        }
        #endregion
/*
        #region "Testing code"
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1123", "value210" };
        }

        [Route("~/FreeWheelMovieApi/v1")]
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "valueGET" + id;
        } 
        #endregion*/
    }
}
