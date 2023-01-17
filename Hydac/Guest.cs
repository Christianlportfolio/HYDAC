using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hydac
{
    public class Guest
    {
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        private string responsibleForVisitor;
        public string ResponsibleForVisitor
        {
            get { return responsibleForVisitor; }
            set { responsibleForVisitor = value; }
        }

        private bool safetyBrochureReceived;
        public bool SafetyBrochureReceived
        {
            get { return safetyBrochureReceived; }
            set { safetyBrochureReceived = value; }
        }

        private DateTime arrival;
        public DateTime Arrival
        {
            get { return arrival; }
            set { arrival = value; }
        }

        private DateTime departure;
        public DateTime Departure
        {
            get { return departure; }
            set { departure = value; }
        }


        // GuestList constructor 
        public Guest(DateTime date, string name, string company, string responsibleForVisitor, bool safetyBrochureReceived)
        {
            this.date = date;
            this.name = name;
            this.company = company;
            this.responsibleForVisitor = responsibleForVisitor;
            this.safetyBrochureReceived = safetyBrochureReceived;
        }

        public Guest(string name)
        {
            Name = name;
        }

        // SaveGuest besked metode
        public string GuestTitle()
        {
            string title = "[Dato: " + date + "] [Gæst: " + name + "] [Virksomhed: " + company + "] [Ansvarlig for besøg: " + responsibleForVisitor + "] [Skal sikkerhedsbrochure udleveres: " + safetyBrochureReceived + "]";
            return title;
        }

        public string ArrivalTitle()
        {
            arrival = DateTime.Now;
            string title = "Gæst: [" + name + "] - ankomst: " + arrival;
            return title;
        }

        public string DepartureTitle()
        {
            departure = DateTime.Now;
            string title = "Gæst: [" + name + "] - afgang: " + departure;
            return title;
        }

        public void SaveGuest()
        {
            StreamWriter personWriter = new StreamWriter("SaveGuest.txt", true);
            personWriter.WriteLine(GuestTitle());
            personWriter.Close();
        }

        public void RegisterArrival()
        {
            StreamWriter arrivalWriter = new StreamWriter("SaveRegisterArrival.txt", true);
            arrivalWriter.Write(ArrivalTitle());
            arrivalWriter.Close();
        }

        public void RegisterDepature()
        {
            StreamWriter DepartureWriter = new StreamWriter("SaveRegisterDeparture.txt", true);
            DepartureWriter.Write(DepartureTitle());
            DepartureWriter.Close();
        }



    }
}
