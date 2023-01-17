using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hydac
{
    public class Booking
    {

        public string Employee { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }

        public Booking() { }

        public Booking(string employee, string name, DateTime dateTime)
        {
            Employee = employee;
            Name = name;
            DateTime = dateTime;
        }


        public string BookingTitle()
        {
            return "[Medarbejder: " + Employee + "] Lokalenavn: [" + Name + "] [Dato og tid: " + DateTime + "]";
        }


        public void SaveBooking()
        {
            StreamWriter bookingWriter = new StreamWriter("SaveBooking.txt", true);
            bookingWriter.WriteLine(BookingTitle());
            bookingWriter.Close();
        }
    }
}
