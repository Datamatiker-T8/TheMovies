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
    /// Interaction logic for AddShow.xaml
    /// </summary>
    public partial class AddShow : Window
    {
        public string SelectedMovie { get; set; }
        public string Cinema { get; set; }
        public string City { get; set; }
        public DateTime Showtime { get; set; }


        public AddShow()
        {
            InitializeComponent();
        }
        private void OK_btn_Click(object sender, RoutedEventArgs e)
        {
            SelectedMovie = Movie_combobox.Text;
            Cinema = Cinema_box.Text;
            City = City_box.Text;
            Showtime = Showtime_box.SelectedDate.Value;
            DialogResult = true;
        }

        private void Cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
