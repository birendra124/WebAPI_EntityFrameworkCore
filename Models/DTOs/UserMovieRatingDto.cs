using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeWheelMovieAPI.Models.DTOs
{
    /// <summary>
    /// DTO model for User to Movie ratingto be used by outside world for clients communications
    /// </summary>
    public class UserMovieRatingDto
    {
        public int Id { get; set; }
        public int RatingStars { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
    }
}
