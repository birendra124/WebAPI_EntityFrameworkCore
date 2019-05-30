using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FreeWheelMovieAPI.Models
{
    public static class ModelBuilderExtensions 
    {
        /// <summary>
        /// Used to load initial data into the tables
        /// </summary>
        /// <param name="modelBuilder">New extension named Seed to modelBuilder class</param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Birendra Mohanraj",
                    Birthdate = new DateTime(1979, 05, 30),
                    IsSubscribedToNewsletter = true
                },
                new User
                {
                    Id = 2,
                    Name = "John Smith",
                    Birthdate = new DateTime(1973, 02, 12),
                    IsSubscribedToNewsletter = false
                },
                new User
                {
                    Id = 3,
                    Name = "Adam Johnson",
                    Birthdate = new DateTime(1970, 12, 30),
                    IsSubscribedToNewsletter = true
                },
                new User
                {
                    Id = 4,
                    Name = "Emilio Venegas",
                    Birthdate = new DateTime(1987, 1, 9),
                    IsSubscribedToNewsletter = false
                },
                new User
                {
                    Id = 5,
                    Name = "Lee Yelverton",
                    Birthdate = new DateTime(1965, 06, 27),
                    IsSubscribedToNewsletter = true
                },
                new User
                {
                    Id = 6,
                    Name = "Alan Appleton",
                    Birthdate = new DateTime(1983, 04, 12),
                    IsSubscribedToNewsletter = false
                },
                new User
                {
                    Id = 7,
                    Name = "Michael Chang",
                    Birthdate = new DateTime(1976, 05, 30),
                    IsSubscribedToNewsletter = true
                },
                new User
                {
                    Id = 8,
                    Name = "Anthony Paul",
                    Birthdate = new DateTime(1963, 02, 16),
                    IsSubscribedToNewsletter = false
                },
                new User
                {
                    Id = 9,
                    Name = "John Pickering",
                    Birthdate = new DateTime(1978, 05, 30),
                    IsSubscribedToNewsletter = true
                },
                new User
                {
                    Id = 10,
                    Name = "Scott Tiger",
                    Birthdate = new DateTime(1993, 07, 18),
                    IsSubscribedToNewsletter = false
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Avengers: EndGame",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 181,
                    ReleaseYear = 2019,
                    AverageRating = 8.9M,
                    NumberAvailable = 10,
                    NumberInStock = 1,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 2,
                    Title = "Captain Marvel",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 123,
                    ReleaseYear = 2019,
                    AverageRating = 7.1M,
                    NumberAvailable = 10,
                    NumberInStock = 7,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 3,
                    Title = "Shazam",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 132,
                    ReleaseYear = 2019,
                    AverageRating = 7.5M,
                    NumberAvailable = 10,
                    NumberInStock = 6,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 4,
                    Title = "Toy Story 4",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 89,
                    ReleaseYear = 2019,
                    AverageRating = 5.1M,
                    NumberAvailable = 10,
                    NumberInStock = 8,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 5,
                    Title = "Godzilla: King of the Monsters",
                    CountryReleased = "United Kingdom",
                    Language = "English",
                    Runningtime = 131,
                    ReleaseYear = 2019,
                    AverageRating = 7.1M,
                    NumberAvailable = 10,
                    NumberInStock = 4,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 6,
                    Title = "Dark Phoenix",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 123,
                    ReleaseYear = 2018,
                    AverageRating = 4.1M,
                    NumberAvailable = 10,
                    NumberInStock = 9,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 7,
                    Title = "Spider-Man: Far from Home",
                    CountryReleased = "Germany",
                    Language = "English",
                    Runningtime = 183,
                    ReleaseYear = 2018,
                    AverageRating = 8.1M,
                    NumberAvailable = 10,
                    NumberInStock = 2,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 8,
                    Title = "The New Mutants",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 147,
                    ReleaseYear = 2018,
                    AverageRating = 3.1M,
                    NumberAvailable = 10,
                    NumberInStock = 9,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 9,
                    Title = "Star Wars",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 198,
                    ReleaseYear = 2018,
                    AverageRating = 8.7M,
                    NumberAvailable = 10,
                    NumberInStock = 3,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                },
                new Movie
                {
                    Id = 10,
                    Title = "Top Gun: Maverick",
                    CountryReleased = "USA",
                    Language = "English",
                    Runningtime = 145,
                    ReleaseYear = 2018,
                    AverageRating = 4.1M,
                    NumberAvailable = 10,
                    NumberInStock = 9,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Action",
                },
                new Genre
                {
                    Id = 2,
                    Name = "Adventure",
                },
                new Genre
                {
                    Id = 3,
                    Name = "Animation",
                },
                new Genre
                {
                    Id = 4,
                    Name = "Biography",
                },
                new Genre
                {
                    Id = 5,
                    Name = "Comedy",
                },
                new Genre
                {
                    Id = 6,
                    Name = "Crime",
                },
                new Genre
                {
                    Id = 7,
                    Name = "Documentary",
                },
                new Genre
                {
                    Id = 8,
                    Name = "Drama",
                },
                new Genre
                {
                    Id = 9,
                    Name = "Family",
                },
                new Genre
                {
                    Id = 10,
                    Name = "Fantasy",
                },
                new Genre
                {
                    Id = 11,
                    Name = "History",
                },
                new Genre
                {
                    Id = 12,
                    Name = "Horror",
                },
                new Genre
                {
                    Id = 13,
                    Name = "Musical",
                },
                new Genre
                {
                    Id = 14,
                    Name = "Mystery",
                },
                new Genre
                {
                    Id = 15,
                    Name = "Romance",
                }
            );

            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre
                {
                    Id = 1,
                    MovieId = 1,
                    GenreId = 1
                },
                new MovieGenre
                {
                    Id = 2,
                    MovieId = 1,
                    GenreId = 2
                },
                new MovieGenre
                {
                    Id = 3,
                    MovieId = 2,
                    GenreId = 1
                },
                new MovieGenre
                {
                    Id = 4,
                    MovieId = 2,
                    GenreId = 2
                },
                new MovieGenre
                {
                    Id = 5,
                    MovieId = 3,
                    GenreId = 1
                },
                new MovieGenre
                {
                    Id = 6,
                    MovieId = 3,
                    GenreId = 2
                },
                new MovieGenre
                {
                    Id = 7,
                    MovieId = 3,
                    GenreId = 5
                },
                new MovieGenre
                {
                    Id = 8,
                    MovieId = 4,
                    GenreId = 2
                },
                new MovieGenre
                {
                    Id = 9,
                    MovieId = 4,
                    GenreId = 3
                },
                new MovieGenre
                {
                    Id = 10,
                    MovieId = 4,
                    GenreId = 5
                },
                new MovieGenre
                {
                    Id = 11,
                    MovieId = 5,
                    GenreId = 1
                },
                new MovieGenre
                {
                    Id = 12,
                    MovieId = 5,
                    GenreId = 2
                },
                new MovieGenre
                {
                    Id = 13,
                    MovieId = 5,
                    GenreId = 10
                },
                new MovieGenre
                {
                    Id = 14,
                    MovieId = 6,
                    GenreId = 1
                },
                new MovieGenre
                {
                    Id = 15,
                    MovieId = 6,
                    GenreId = 2
                },
                new MovieGenre
                {
                    Id = 16,
                    MovieId = 6,
                    GenreId = 15
                },
                new MovieGenre
                {
                    Id = 17,
                    MovieId = 7,
                    GenreId = 13
                },
                new MovieGenre
                {
                    Id = 18,
                    MovieId = 8,
                    GenreId = 14
                },
                new MovieGenre
                {
                    Id = 19,
                    MovieId = 9,
                    GenreId = 15
                },
                new MovieGenre
                {
                    Id = 20,
                    MovieId = 10,
                    GenreId = 11
                },
                new MovieGenre
                {
                    Id = 21,
                    MovieId = 10,
                    GenreId = 12
                }
            );

            modelBuilder.Entity<UserMovieRating>().HasData(
                new UserMovieRating
                {
                    Id = 1,
                    RatingStars = 5,
                    MovieId = 1,
                    UserId = 1
                },
                new UserMovieRating
                {
                    Id = 2,
                    RatingStars = 4,
                    MovieId = 2,
                    UserId = 2
                },
                new UserMovieRating
                {
                    Id = 3,
                    RatingStars = 4,
                    MovieId = 1,
                    UserId = 3
                },
                new UserMovieRating
                {
                    Id = 4,
                    RatingStars = 5,
                    MovieId = 1,
                    UserId = 4
                },
                new UserMovieRating
                {
                    Id = 5,
                    RatingStars = 4,
                    MovieId = 1,
                    UserId = 5
                },
                new UserMovieRating
                {
                    Id = 6,
                    RatingStars = 1,
                    MovieId = 2,
                    UserId = 1
                },
                new UserMovieRating
                {
                    Id = 7,
                    RatingStars = 2,
                    MovieId = 3,
                    UserId = 1
                },
                new UserMovieRating
                {
                    Id = 8,
                    RatingStars = 4,
                    MovieId = 4,
                    UserId = 1
                },
                new UserMovieRating
                {
                    Id = 9,
                    RatingStars = 3,
                    MovieId = 1,
                    UserId = 2
                },
                new UserMovieRating
                {
                    Id = 10,
                    RatingStars = 3,
                    MovieId = 5,
                    UserId = 2
                },
                new UserMovieRating
                {
                    Id = 11,
                    RatingStars = 5,
                    MovieId = 6,
                    UserId = 2
                },
                new UserMovieRating
                {
                    Id = 12,
                    RatingStars = 3,
                    MovieId = 10,
                    UserId = 1
                },
                new UserMovieRating
                {
                    Id = 13,
                    RatingStars = 2,
                    MovieId = 10,
                    UserId = 10
                },
                new UserMovieRating
                {
                    Id = 14,
                    RatingStars = 3,
                    MovieId = 9,
                    UserId = 1
                },
                new UserMovieRating
                {
                    Id = 15,
                    RatingStars = 5,
                    MovieId = 8,
                    UserId = 1
                },
                new UserMovieRating
                {
                    Id = 16,
                    RatingStars = 3,
                    MovieId = 6,
                    UserId = 7
                },
                new UserMovieRating
                {
                    Id = 17,
                    RatingStars = 5,
                    MovieId = 4,
                    UserId = 7
                }

            );
        }
    }
}
