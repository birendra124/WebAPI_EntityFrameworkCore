using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FreeWheelMovieAPI.Models;
using FreeWheelMovieAPI.Models.Repository;

namespace FreeWheelMovieAPI.Controllers
{
    [Route("FreeWheelMovieApi/v1/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDBContext _context;
        private readonly IDataRepository<Movie> _dataRepository;

        public MoviesController(MovieDBContext context, IDataRepository<Movie> dataRepository)
        {
            _dataRepository = dataRepository;
            _context = context;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {

            IEnumerable<Movie> movies = await _context.Movies.ToListAsync();// _dataRepository.GetAll();
            return Ok(movies);
          //  return await _dataRepository.Movies.ToListAsync();
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {

            var movie = await _context.Movies.FindAsync(id); //_dataRepository.Get(id);

            if (movie == null)
            {
                return NotFound("The Movie record couldn't be found.");
            }

            return Ok(movie);

           // var movie = await _dataRepository.Movies.FindAsync(id);

            //if (movie == null)
            //{
            //    return NotFound();
            //}

            //return movie;
        }

        //// PUT: api/Movies/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMovie(int id, Movie movie)
        //{
        //    if (id != movie.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _dataRepository.Entry(movie).State = EntityState.Modified;

        //    try
        //    {
        //        await _dataRepository.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MovieExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Movies
        //[HttpPost]
        //public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        //{
        //    _dataRepository.Movies.Add(movie);
        //    await _dataRepository.SaveChangesAsync();

        //    return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        //}

        //// DELETE: api/Movies/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Movie>> DeleteMovie(int id)
        //{
        //    var movie = await _dataRepository.Movies.FindAsync(id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    _dataRepository.Movies.Remove(movie);
        //    await _dataRepository.SaveChangesAsync();

        //    return movie;
        //}

        //private bool MovieExists(int id)
        //{
        //    return _dataRepository.Movies.Any(e => e.Id == id);
        //}
    }
}
