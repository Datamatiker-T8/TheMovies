using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
{
    public class Show
    {
        private DateTime showTime;
        public DateTime ShowTime
        {
            get { return showTime; }
            set { showTime = value; }
        }

        public Movie ShowThisMovie { get; set; }
        public Cinema InThisCinama { get; set; }

        public Show(DateTime Showtime)
        {
            showTime = Showtime;

        }

    }
}
