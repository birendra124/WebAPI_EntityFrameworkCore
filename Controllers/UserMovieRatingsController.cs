using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FreeWheelMovieAPI.Models;

namespace FreeWheelMovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMovieRatingsController : ControllerBase
    {
        private readonly MovieDBContext _context;

        public UserMovieRatingsController(MovieDBContext context)
        {
            _context = context;
        }

        // GET: api/UserMovieRatings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserMovieRating>>> GetUserMovieRatings()
        {
            return await _context.UserMovieRatings.ToListAsync();
        }

        // GET: api/UserMovieRatings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserMovieRating>> GetUserMovieRating(int id)
        {
            var userMovieRating = await _context.UserMovieRatings.FindAsync(id);

            if (userMovieRating == null)
            {
                return NotFound();
            }

            return userMovieRating;
        }

        // PUT: api/UserMovieRatings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserMovieRating(int id, UserMovieRating userMovieRating)
        {
            if (id != userMovieRating.Id)
            {
                return BadRequest();
            }

            _context.Entry(userMovieRating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserMovieRatingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserMovieRatings
        [HttpPost]
        public async Task<ActionResult<UserMovieRating>> PostUserMovieRating(UserMovieRating userMovieRating)
        {
            _context.UserMovieRatings.Add(userMovieRating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserMovieRating", new { id = userMovieRating.Id }, userMovieRating);
        }

        // DELETE: api/UserMovieRatings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserMovieRating>> DeleteUserMovieRating(int id)
        {
            var userMovieRating = await _context.UserMovieRatings.FindAsync(id);
            if (userMovieRating == null)
            {
                return NotFound();
            }

            _context.UserMovieRatings.Remove(userMovieRating);
            await _context.SaveChangesAsync();

            return userMovieRating;
        }

        private bool UserMovieRatingExists(int id)
        {
            return _context.UserMovieRatings.Any(e => e.Id == id);
        }
    }
}
