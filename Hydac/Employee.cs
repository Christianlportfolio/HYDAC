using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hydac
{
    public enum Smiley
    {
        happy,
        neutral,
        sad
    }
    public class Employee
    {
        private string name;
        private string position;
        private string team;
        private Smiley smiley;
        private bool present;


        public string Name { get; set; }

        public string Position { get; set; }
        
        public string Team { get; set; }
        
        public string Smiley { get; set; }
        

        public Employee(string name)
        {
            this.name = name;
        }
        
        public Employee(string name, string position, string team) : this(name)
        {
            this.position = position;
            this.team = team;
        }

        public void SaveEmployee()
        {
            StreamWriter employeeWriter = new StreamWriter("PersonnelFile.txt", true);
            employeeWriter.WriteLine(name + ";" + position + ";" + team);
            employeeWriter.Close();
        }

        public void CheckIn(string name, int mood)
        {
            switch (mood)
            {
                case 1:
                    {
                        smiley = Hydac.Smiley.happy;
                        break;
                    }
                case 2:
                    {
                        smiley = Hydac.Smiley.neutral;
                        break;
                    }
                case 3:
                    {
                        smiley = Hydac.Smiley.sad;
                        break;
                    }
            }
            StreamWriter arrivalWriter = new StreamWriter("Arrival.txt",true);
            arrivalWriter.WriteLine("Name: " + name + ";Smiley: " + smiley + ";Arrival: " + DateTime.Now);
            arrivalWriter.Close();
            //present = true;
        }

        public void CheckOut(string name)
        {
            StreamWriter departureWriter = new StreamWriter("Departure.txt", true);
            departureWriter.WriteLine("Name: " + name + ";Departure: " + DateTime.Now);
            departureWriter.Close();
            present = false;
        }
    }
}
