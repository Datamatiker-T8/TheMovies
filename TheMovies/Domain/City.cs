﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
{
    public class City
    {
        public string Name { get; set; }

        public City(string name)
        {
            this.Name = name;
        }
    }
}
