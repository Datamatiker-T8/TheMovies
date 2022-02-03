using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Booking
    {
        private string bookingEmail;

        public string BookingEmail
        {
            get { return bookingEmail; }
            set { bookingEmail = value; }
        }
        private int bookingPhoneNumber;

        public int BookingPhoneNumber
        {
            get { return bookingPhoneNumber; }
            set { bookingPhoneNumber = value; }
        }
        public Booking ()
        {

        }


    }
}
