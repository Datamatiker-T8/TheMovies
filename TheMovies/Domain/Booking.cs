using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
{
    public class Booking
    {
        public string Mail { get; set; }
        public string Phonenumber { get; set; }

        public Booking(string mail, string phonenumber)
        {
            this.Mail = mail;
            this.Phonenumber = phonenumber;
        }
    }
}
