using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Domain;

namespace TheMovies.Presistence
{
    public class Repository
    {

        // CityViewModel => Repository.CityItems

        public List<City> CityItems;
        public List<Cinema> CinemaItems;
        public List<Movie> MovieItems;
        public List<Show> ShowItems;
        public List<Booking> BookingItems;
        public string FilePath { get; set; }

        public Repository(string filePath)
        {
            FilePath = filePath;
        }

        public void LoadItems()
        {
            string[] itemsStringArray = File.ReadAllLines(FilePath);

            List<string> cinemaNames = new();
            List<string> cityNames = new();
            List<string> showItems = new();
            List<string> movieTitle = new();
            List<string> bookingPhonenumber = new();

            for (int i=0; i < itemsStringArray.Length; i++) // Seperates CSV files coloumns into array/Lists foreach their respective itemclass
            {
                string[] currentItem = itemsStringArray[i].Split(";");

                cinemaNames.Add(currentItem[0]);
                cityNames.Add(currentItem[1]);
                showItems.Add(currentItem[2]);
                movieTitle.Add(currentItem[3]);
                bookingPhonenumber.Add(currentItem[9]);
            }

            // Removes duplicates
            List<string> totalCityNames = cityNames.Distinct().ToList();
            List<string> totalCinemaNames = cinemaNames.Distinct().ToList();
            List<string> totalMovieTitles = movieTitle.Distinct().ToList();
            List<string> totalShows = movieTitle.Distinct().ToList();
            List<string> totalBookingPhonenumber = bookingPhonenumber.Distinct().ToList();

            foreach (string city in totalCityNames)
            {
                City c = new(city);
                CityItems.Add(c);
            }

            foreach (string cinema in totalCinemaNames)
            {
                Cinema c = new(cinema);
                CinemaItems.Add(c);
            }

            foreach (string show in totalShows)
            {
                Show s = new(DateTime.Parse(show));
                ShowItems.Add(s);
            }

            foreach (string movie in totalMovieTitles)
            {
                int currentindex = totalMovieTitles.IndexOf(movie);
                string[] currentItem = itemsStringArray[currentindex].Split(";");

                Movie m = new(
                    currentItem[3],
                    currentItem[4],
                    TimeSpan.Parse(currentItem[5]),
                    currentItem[6],
                    DateTime.Parse(currentItem[7])
                    );

                MovieItems.Add(m);
            }

            foreach (string booking in totalBookingPhonenumber)
            {
                int currentindex = totalBookingPhonenumber.IndexOf(booking);
                string[] currentItem = itemsStringArray[currentindex].Split(";");

                Booking b = new(currentItem[8], currentItem[9]);
                BookingItems.Add(b);
            }
        }

        public void Saveitems()
        {
            // TODO: Assotiation bestween city and cinema
        }
    }
}
