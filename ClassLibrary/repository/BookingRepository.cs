using System;
using System.Collections.Generic;

namespace ClassLibrary.repository
{
    public class BookingRepository
    {
        private List<Booking> bookings = new List<Booking>();

        public void TilføjBooking(Booking booking)
        {
            bookings.Add(booking);
        }

        public List<Booking> HentAlleBookings()
        {
            return bookings;
        }

        public bool ErTom()
        {
            return bookings.Count == 0;
        }
    }
}
