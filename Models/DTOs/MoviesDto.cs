using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeWheelMovieAPI.Models.DTOs
{
    /// <summary>
    /// DTO model for User to Movies details to be used by outside world for clients communications
    /// </summary>
    public class MoviesDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
        public int RunningTime { get; set; }
        public decimal AverageRating { get; set; }
        public string Generes { get; set; }
    }
}
