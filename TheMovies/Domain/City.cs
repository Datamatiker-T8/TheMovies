using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class City
    {
        private string name;

		public string Name
		{
			get { return name;}
			set { name = value;}
		}
		public City(string Name)
        {
            this.name = Name;
            
        }

    }
}
