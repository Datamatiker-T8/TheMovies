using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Presistence;

namespace TheMovies.Domain
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Duration { get; set; }
        public string Director { get; set; }
        public DateTime PremierDate { get; set; }

        public Movie(string title, double duration, string director, DateTime premierDate)
        {
            this.Title = title;
            this.Duration = duration;
            this.Director = Director;
            this.PremierDate = premierDate;
        }

    }
}
