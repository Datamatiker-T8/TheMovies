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
using System.Windows.Shapes;

namespace TheMovies.Views
{
    /// <summary>
    /// Interaction logic for AddMovie.xaml
    /// </summary>
    public partial class AddMovie : Window
    {
        public string MovieTitle { get; set; }
        public string MovieGenre { get; set; }
        public double MovieDuration { get; set; }
        public string MovieDirector { get; set; }
        public DateTime MoviePremierDate { get; set; }

        public AddMovie()
        {
            InitializeComponent();
        }

        private void OK_btn_Click(object sender, RoutedEventArgs e)
        {
            MovieTitle = MovieTitle_box.Text;
            MovieGenre = MovieGenre_box.Text;
            MovieDuration = double.Parse(MovieDuration_box.Text);
            MovieDirector = MovieDirector_box.Text;
            MoviePremierDate = MoviePremier_box.SelectedDate.Value;
            DialogResult = true;
        }

        private void Cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
