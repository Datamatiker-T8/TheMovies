﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Presistence;

namespace TheMovies.ViewModels
{
    public class MovieViewModel
    {
        MovieRepository movieRepo = new MovieRepository();
        public void AddMovie(string title, string genre, double duration, string director, DateTime premierDate)
        {
            movieRepo.Create(title, genre, duration, director, premierDate);
        }
    }
}
