using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.ViewModels
{
    public class MainViewModel
    {
        public void AddMovie(Movie me)
        {
            
        }
        public void RemoveMovie(Movie me)
        {
            
        }

        public void AddCity(City cy)
        {
            
        }
        public void RemoveCity(City cy)
        {
            
        }

        public void AddGenre (Genre ge)
        {
            Genre.Remove(ge);//fjerner fra liste (ikke lavet endnu)
            pr.Delete(); //fjerner fra filen inden i MoviesViewModel
        }
      
        public void RemoveGenre(Genre ge)
        {
            
        }
    }
}
