using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FreeWheelMovieAPI.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        [Column(TypeName = "decimal(2, 1)")]
        public decimal AverageRating { get; set; }

        [Required]
        public int Runningtime { get; set; }

        public string Language { get; set; }

        public string CountryReleased { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<UserMovieRating> UserMovieRatings { get; set; }
    }
}
