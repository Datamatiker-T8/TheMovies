using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
{
    public class Genre
    {
        public string Name { get; set; }

        public Genre(string name)
        {
            this.Name = name;
        }
    }
}
