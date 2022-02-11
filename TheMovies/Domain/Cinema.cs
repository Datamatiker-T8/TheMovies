using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
{
    public class Cinema
    {
        public string Name { get; set; }

        public Cinema(string name)
        {
            this.Name = name;
        }
    }
}
