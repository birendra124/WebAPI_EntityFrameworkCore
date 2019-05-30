using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeWheelMovieAPI.Models.Repository
{
    /// <summary>
    /// Generic interface to be implemented by all repositories
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }

    /// <summary>
    /// Interface to be implemented only by Genere implementation class
    /// </summary>
    public interface IGenreDataRepository
    {
        IEnumerable<Genre> GetGenres(int movieId);
    }
}
