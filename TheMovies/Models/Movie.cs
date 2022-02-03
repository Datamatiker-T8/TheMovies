using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Movie
    {
        private string title;

		public string Title
		{
			get { return title;}
			set { title = value;}
		}
		private int lenght;

		public int Lenght
		{
			get { return lenght;}
			set { lenght = value;}
		}
		private string instructor;

		public string Instructor
		{
			get { return instructor;}
			set { instructor = value;}
		}
		private DateTime duration;

		public DateTime Duration
		{
			get { return duration;}
			set { duration = value;}
		}
		private DateTime premierDate;

		public DateTime PremierDate
		{
			get { return premierDate;}
			set { premierDate = value;}
		}
        private string genre;

		public string Genre
		{
			get { return genre;}
			set { genre = value;}
		}
		public void Parse(string line)
        {
            string[] data = line.Split(';');
            Title = data[0];
            Instructor = data[1];
            SocialSecurityNumber = int.Parse(data[2]);
            PhoneNumber = int.Parse(data[3]);
            Address = data[4];
            AccountNumber = int.Parse(data[5]);
        }

		public string Format()
        {
            return $"";
        }

    }
}
