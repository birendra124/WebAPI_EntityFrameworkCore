using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeWheelMovieAPI.Models.Filters
{
    public class MovieSearchFilters
    {
        public string title;
        public int yearOfRelease;
        public List<string> generes;
    }
}
