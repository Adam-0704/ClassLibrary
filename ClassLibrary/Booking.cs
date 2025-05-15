using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Booking
    {
        public int BookingId { get; set; }
        
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }

        public Booking(int bookingid, int boatid, int medlemid, DateTime startdato, DateTime slutdato)
        {
            

        }


        public void VisInfo()
        {
            
        }



    }
}
