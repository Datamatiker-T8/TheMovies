using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Domain;

namespace TheMovies.Presistence
{
    public class MovieRepository
    {

        string conString = "Server=10.56.8.36;Database=P1DB08;User Id=P1-08;Password=OPENDB_08;";
        List<Movie> movies = new List<Movie>();

        public Movie Create(string title, string genre, double duration, string director, DateTime premierDate) 
        {
            Movie movie = new Movie(title, genre, duration, director, premierDate);
            movies.Add(movie);

            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = $"INSERT INTO Movie VALUES (@title, @genre, @duration, @director, @premierDate)";
                
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@premierDate", premierDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            return movie;
        }
        public void ReadOne() { }
        public List<Movie> ReadAll() 
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string sql = $"SELECT Title, Genre, Duration, Director, Premierdate FROM Movie";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read() != false)
                        {
                            movies.Add(new Movie(reader["Title"].ToString(), reader["Genre"].ToString(), (double)reader["Duration"], reader["Director"].ToString(), (DateTime)reader["Premierdate"]));
                        }
                    }
                }

                con.Close();
            }
                return movies;
        }
        public void Update() { }
        public void Delete() { }
    }
}
