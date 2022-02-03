using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Show
    {
        private DateTime showTime;

        public DateTime ShowTime
        {
            get { return showTime; }
            set { showTime = value; }
        }

        public Show(DateTime Showtime)
        {
            showTime = Showtime;

        }

    }
}
