using Microsoft.EntityFrameworkCore;

namespace FreeWheelMovieAPI.Models
{
    /// <summary>
    /// Main DBContext class for database operations.
    /// </summary>
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<UserMovieRating> UserMovieRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Initialize test data.
            modelBuilder.Seed();
        }
    }
}
