using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheMovies.ViewModels;

namespace TheMovies.Views
{
    /// <summary>
    /// Interaction logic for OversigtWindow.xaml
    /// </summary>
    public partial class OversigtWindow : Page
    {
        MovieViewModel mvm = new MovieViewModel();

        public OversigtWindow()
        {
            InitializeComponent();
        }

        private void AddMovie_Click(object sender, RoutedEventArgs e)
        {
            AddMovie AddMovie = new AddMovie();

            if (AddMovie.ShowDialog() == true)
            {
                mvm.AddMovie(AddMovie.MovieTitle, AddMovie.MovieGenre, AddMovie.MovieDuration, AddMovie.MovieDirector, AddMovie.MoviePremierDate);
            }
        }
    }
}
