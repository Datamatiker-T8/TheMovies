using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Domain
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
        public Booking (string bookingEmail, int bookingPhoneNumber)
        {
            this.BookingPhoneNumber = bookingPhoneNumber;
            this.bookingEmail = bookingEmail;
        }


    }
}
