using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeWheelMovieAPI.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace FreeWheelMovieAPI.Models.DataManagers
{
    public class GenreManager : IDataRepository<Genre>, IGenreDataRepository
    {
        readonly MovieDBContext _movieDBContext;

        public GenreManager(MovieDBContext context)
        {
            _movieDBContext = context;
        }

        public IEnumerable<Genre> GetAll()
        {
            return _movieDBContext.Genres.ToList();
        }

        public Genre Get(int id)
        {
            return _movieDBContext.Genres.FirstOrDefault(x=> x.Id == id);
        }

        public IEnumerable<Genre> GetGenres(int movieId)
        //public IEnumerable<Genre> IGenreDataRepository<Genre>.GetGenres(int movieId)
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
        //public List<Genre> GetGenres(int movieId)
        //{
        //    var genres = (from M in _movieDBContext.Movies
        //                  join MG in _movieDBContext.MovieGenres on M.Id equals MG.MovieId
        //                  join G in _movieDBContext.Genres on MG.GenreId equals G.Id
        //                  where (MG.Id == movieId)
        //                  select new Genre
        //                  {
        //                      Id = M.Id,                              
        //                      Name = G.Name
        //                  })?.ToList();

        //    return genres;
        //}

        public void Add(Genre entity)
        {
            _movieDBContext.Genres.Add(entity);
            _movieDBContext.SaveChanges();
        }

        public void Update(Genre genre, Genre entity)
        {
            //movie.Title = entity.Title;
            //movie.LastName = entity.LastName;
            //movie.Email = entity.Email;
            //movie.DateOfBirth = entity.DateOfBirth;
            //movie.PhoneNumber = entity.PhoneNumber;

            _movieDBContext.SaveChanges();
        }

        public void Delete(Genre genre)
        {
            _movieDBContext.Genres.Remove(genre);
            _movieDBContext.SaveChanges();
        }

    }
}
