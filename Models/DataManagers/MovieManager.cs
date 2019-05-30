using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeWheelMovieAPI.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace FreeWheelMovieAPI.Models.DataManagers
{
    public class MovieManager : IDataRepository<Movie>
    {
        readonly MovieDBContext _movieDBContext;

        public MovieManager(MovieDBContext context)
        {
            _movieDBContext = context;
        }

        public IEnumerable<Movie> GetAll()
        {
            return _movieDBContext.Movies.ToList();
        }

        public Movie Get(int id)
        {
            return  _movieDBContext.Movies.FirstOrDefault(x=> x.Id == id);
        }

        public void Add(Movie entity)
        {
            _movieDBContext.Movies.Add(entity);
            _movieDBContext.SaveChanges();
        }

        public void Update(Movie movie, Movie entity)
        {
            movie = entity;
            //movie.Title = entity.Title;
            //movie.LastName = entity.LastName;
            //movie.Email = entity.Email;
            //movie.DateOfBirth = entity.DateOfBirth;
            //movie.PhoneNumber = entity.PhoneNumber;

            _movieDBContext.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            _movieDBContext.Movies.Remove(movie);
            _movieDBContext.SaveChanges();
        }
    }
}
