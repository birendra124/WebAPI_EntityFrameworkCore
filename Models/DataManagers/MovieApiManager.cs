using FreeWheelMovieAPI.Models.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeWheelMovieAPI.Models.DTOs;
using FreeWheelMovieAPI.Models.Repository;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace FreeWheelMovieAPI.Models.DataManagers
{
    /// <summary>
    /// Actual concrete class that manages or implements the Movie APIs repository.
    /// </summary>
    public class MovieApiManager : IMovieApiRepository
    {
        #region "Public functions"

        public Task<List<Movie>> SearchMovies(MovieSearchFilters filter)
        {
            try
            {
                var movies = (from M in _movieDBContext.Movies
                              join MG in _movieDBContext.MovieGenres on M.Id equals MG.MovieId
                              join G in _movieDBContext.Genres on MG.GenreId equals G.Id
                              where (filter.yearOfRelease <= 0 || M.ReleaseYear == filter.yearOfRelease) &&
                                  (string.IsNullOrEmpty(filter.title) || M.Title.Contains(filter.title)) &&
                                  (filter == null ||
                                  filter.generes == null ||
                                  filter.generes.Count <= 0 ||
                                  filter.generes.Any(x => x.ToLower().Trim() == G.Name.ToLower().Trim()))
                              select new Movie
                              {
                                  Id = M.Id,
                                  Title = M.Title,
                                  ReleaseYear = M.ReleaseYear,
                                  Runningtime = M.Runningtime,
                                  AverageRating = M.AverageRating
                              })?.ToList();
                var distinctMovies = movies
                        .GroupBy(x => x.Id)
                        .Select(x => x.First())?.ToList();
                return Task.FromResult(distinctMovies);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<Movie>> GetUserAverageTopRatedMovies(int numberOfMovies)
        {
            try
            {/*
                string sql = "  select top 5 umr.MovieId, title, ReleaseYear, RunningTime, AverageRating," +
                                " STRING_AGG(g.[name], N', ')  WITHIN GROUP(order BY g.[name]) as generes," +
                                " avg(cast(RatingStars AS DECIMAL(10, 2))) as AvgRating " +
                                " from UserMovieRatings umr join movies m on umr.MovieId = m.Id " +
                                " join MovieGenres mg on mg.MovieId = m.Id" +
                                " join genres g on g.Id = mg.GenreId " +
                                " group by umr.MovieId,title, ReleaseYear, RunningTime, AverageRating " +
                                " order by AvgRating desc, Title asc";*/
                //var q = _movieDBContext.Movies.FromSql(sql);
                //.Where(x => x.MovieId == _movieDBContext.Movies.Select(m => m.Id == x.MovieId)
                //.GroupBy(l => l.MovieId)
                var movies = (from umr in _movieDBContext.UserMovieRatings
                              join m in _movieDBContext.Movies on umr.MovieId equals m.Id
                              group umr by umr.MovieId into g
                              select new Movie
                              {
                                  Id = g.Key,
                                  AverageRating = (decimal)Math.Round(g.Average(item => item.RatingStars) * 2, MidpointRounding.ToEven) / 2
                              }).Take(numberOfMovies)?.ToList();
                movies = movies?.OrderByDescending(x => x.AverageRating)?.ThenBy(y => y.Title)?.ToList();
                foreach (Movie movie in movies)
                {
                    var movieDetails = _movieDBContext.Movies.FirstOrDefault(x => x.Id == movie.Id);
                    movie.Runningtime = movieDetails.Runningtime;
                    movie.Title = movieDetails.Title;
                    movie.ReleaseYear = movieDetails.ReleaseYear;
                }
                return Task.FromResult(movies);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<Movie>> GetUserHighestRatedMovies(int userId, int noOfRatings)
        {
            try
            {
                /* string sql = " select top 100 m.Id, title, ReleaseYear, RunningTime, AverageRating," +
                               " STRING_AGG(g.[name], N', ')  WITHIN GROUP(order BY g.[name]) as generes," +
                               " max(RatingStars) as RatingStars " +
                               " from UserMovieRatings umr join movies m on umr.MovieId = m.Id "+
                               " join MovieGenres mg on mg.MovieId = m.Id "+
                               " join genres g on g.Id = mg.GenreId " +
                               " where umr.UserId = 10 " +
                               " group by m.Id, Title, ReleaseYear, RunningTime, AverageRating "+
                               " order by RatingStars desc, Title asc";*/
                //var q = _movieDBContext.Movies.FromSql(sql);
                var movies = (from umr in _movieDBContext.UserMovieRatings
                              join m in _movieDBContext.Movies on umr.MovieId equals m.Id
                              where umr.UserId == userId
                              group umr by umr.MovieId into g
                              select new Movie
                              {
                                  Id = g.Key,
                                  AverageRating = g.Max(item => item.RatingStars),
                              }).Take(noOfRatings)?.ToList();
                movies = movies?.OrderByDescending(x => x.AverageRating)?.ThenBy(y => y.Title)?.ToList();
                foreach (Movie movie in movies)
                {
                    var movieDetails = _movieDBContext.Movies.FirstOrDefault(x => x.Id == movie.Id);
                    movie.Runningtime = movieDetails.Runningtime;
                    movie.Title = movieDetails.Title;
                    movie.ReleaseYear = movieDetails.ReleaseYear;
                }
                return Task.FromResult(movies);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> UserMovieRatingsUpsert(UserMovieRating userMovieRating)
        {
            try
            {
                UserMovieRating existingUserMovieRating = await userMovieRatingExists(userMovieRating);
                if (existingUserMovieRating != null)
                {   // Updating existing record with new ratingstars set by user for movie.
                    existingUserMovieRating.RatingStars = userMovieRating.RatingStars;
                    return await _movieDBContext.SaveChangesAsync();
                }
                else
                {   // Inserting new record for user's movie rating
                    _movieDBContext.UserMovieRatings.Add(userMovieRating);
                    return await _movieDBContext.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region "Constructor with dependency injections"
        public MovieApiManager(MovieDBContext context, IMapper mapper)
        {
            _movieDBContext = context;
            _mapper = mapper;
        }
        #endregion

        #region "Private members"
        private readonly MovieDBContext _movieDBContext;
        private readonly IMapper _mapper;
        #endregion

        #region "Private functions"
        private async Task<UserMovieRating> userMovieRatingExists(UserMovieRating userMovieRating)
        {
            var existingUserMovieRating = await _movieDBContext.UserMovieRatings.FirstOrDefaultAsync(e =>
                                                                            e.UserId == userMovieRating.UserId &&
                                                                            e.MovieId == userMovieRating.MovieId);
            return existingUserMovieRating;
        }

        private List<Genre> getGenres(int movieId)
        {
            var genres = (from M in _movieDBContext.Movies
                          join MG in _movieDBContext.MovieGenres on M.Id equals MG.MovieId
                          join G in _movieDBContext.Genres on MG.GenreId equals G.Id
                          where (MG.MovieId == movieId)
                          select new Genre
                          {
                              Id = M.Id,
                              Name = G.Name
                          })?.ToList();

            return genres;
        }
        #endregion
    }
}
