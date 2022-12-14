using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    struct Films
    {
        public string Film { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }

        public Films(string film, string genre, int year, int duration)
        {
            Film = film;
            Genre = genre;
            Year = year;
            Duration = duration;
        }
    }
}
