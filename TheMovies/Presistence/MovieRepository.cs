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

        string conString = "Server=10.56.8.36;Database=DB67;User Id=STUDENT67;Password=OPENDB_67;";
        List<Movie> movies = new List<Movie>();

        public void Create(string title, double duration, string director, DateTime premierDate) 
        {
            movies.Add(new Movie(title, duration, director, premierDate));

            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = $"INSERT INTO Movie VALUES (@title, @duration, @director, @premierDate)";
                
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@director", director);
                    cmd.Parameters.AddWithValue("@premierDate", premierDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public void Read() { }
        public void Update() { }
        public void Delete() { }
    }
}
