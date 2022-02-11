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
        private string bookingPhoneNumber;

        public string BookingPhoneNumber
        {
            get { return bookingPhoneNumber; }
            set { bookingPhoneNumber = value; }
        }

        private Show ShowForBooking;

        public Show showForBooking
        {
            get { return ShowForBooking; }
            set { ShowForBooking = value; }
        }


        public Booking (string bookingEmail, string bookingPhoneNumber)
        {
            this.BookingPhoneNumber = bookingPhoneNumber;
            this.bookingEmail = bookingEmail;
        }


    }
}
