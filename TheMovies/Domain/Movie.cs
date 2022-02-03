using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Presistence;

namespace TheMovies.Models
{
    public class Movie : IDomainItem
    {
        private string title;

		public string Title
		{
			get { return title;}
			set { title = value;}
		}
		
		private string instructor;

		public string Instructor
		{
			get { return instructor;}
			set { instructor = value;}
		}
		private TimeSpan duration;//String hourMinute = DateTime.Now.ToString("HH:mm"); burde virke, til at vise længden af filmen

		public TimeSpan Duration
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
		public Movie(
			string title, 
			string genre, 
			TimeSpan duration, 
			string instructor, 
			DateTime premierDate)
        {
			this.title = title;
			this.genre = genre;
			this.duration = duration;
			this.instructor = instructor;
			this.premierDate = premierDate;


		}
		public void Parse(string line)
        {
            
        }

		public string Format()
        {
            return $"";
        }

    }
}
