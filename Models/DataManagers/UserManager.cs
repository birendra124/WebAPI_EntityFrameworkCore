using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeWheelMovieAPI.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace FreeWheelMovieAPI.Models.DataManagers
{
    public class UserManager : IDataRepository<User>
    {
        readonly MovieDBContext _movieDBContext;

        public UserManager(MovieDBContext context)
        {
            _movieDBContext = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _movieDBContext.Users.ToList();
        }

        public User Get(int id)
        {
            return _movieDBContext.Users.Find(id);
                  //.FirstOrDefault(e => e.Id == id);
        }

        public void Add(User entity)
        {
            _movieDBContext.Users.Add(entity);
            _movieDBContext.SaveChanges();
        }

        public void Update(User movie, User entity)
        {
           // movie.Title = entity.Title;
            //movie.LastName = entity.LastName;
            //movie.Email = entity.Email;
            //movie.DateOfBirth = entity.DateOfBirth;
            //movie.PhoneNumber = entity.PhoneNumber;

            _movieDBContext.SaveChanges();
        }

        public void Delete(User user)
        {
            _movieDBContext.Users.Remove(user);
            _movieDBContext.SaveChanges();
        }
    }
}
