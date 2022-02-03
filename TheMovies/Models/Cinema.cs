using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Cinema
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Cinema(string Name)
        {
            this.Name = Name;
        }

    }
}
