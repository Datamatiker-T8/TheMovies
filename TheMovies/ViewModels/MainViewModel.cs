using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.ViewModels
{
    public class MainViewModel
    {
        public void AddMovie(Movie pr)
        {
            
        }

        public void AddCity(City tn)
        {
            
        }

        public void AddGenre (Genre pr)
        {
            Genre.Remove(pr);//fjerner fra liste (ikke lavet endnu)
            pr.Delete(); //fjerner fra filen inden i MoviesViewModel
        }
      
        public void RemoveGenre(Genre tn)
        {
            
        }
    }
}
