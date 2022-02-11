using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
{
    public class Show
    {
        public DateTime ShowTime { get; set; }

        public Show(DateTime showTime)
        {
            this.ShowTime = showTime;
        }
    }
}
