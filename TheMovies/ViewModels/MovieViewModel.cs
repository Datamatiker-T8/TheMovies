
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Domain;
using TheMovies.Presistence;

namespace TheMovies.ViewModels
{
    public class MovieViewModel
    {
        MovieRepository movieRepo = new MovieRepository();
        public ObservableCollection<Movie> MovieVM { get; set; }

        public MovieViewModel()
        {
            MovieVM = new ObservableCollection<Movie>();

            foreach (Movie movie in GetAllMovies())
            {
                MovieVM.Add(movie);
            }
        }

        public void AddMovie(string title, string genre, double duration, string director, DateTime premierDate)
        {
            Movie movie = movieRepo.Create(title, genre, duration, director, premierDate);
            MovieVM.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
            return movieRepo.ReadAll();
        }
    }
}
