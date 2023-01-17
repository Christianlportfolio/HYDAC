using System;
using System.IO;

namespace Hydac
{
    class Program
    {
        static void Main(string[] args)
        {
            int MainMenuInput = 0;
            do
            {
                //Main menu
                Console.Clear();
                Console.WriteLine("Welcome to Hydac");
                Console.WriteLine("Please choose which menu you want to enter:");
                Console.WriteLine("1: Employee menu");
                Console.WriteLine("2: Guest menu");
                Console.WriteLine("3: Booking menu");

                Console.WriteLine("\nPlease enter a number to continue. Type 4 to exit");
                MainMenuInput = int.Parse(Console.ReadLine());

                switch (MainMenuInput)
                {
                    case 1: //Go to Employee Menu
                        {
                            int EmployeeMenuinput = 0;
                            do
                            {
                                //Employee menu
                                Console.Clear();
                                Console.WriteLine("Welcome to the Employee menu");
                                Console.WriteLine("Do you want to:");
                                Console.WriteLine("1: Check in");
                                Console.WriteLine("2: Check out");
                                Console.WriteLine("3: Register new employee");

                                //Register user input
                                Console.WriteLine("\nPlease enter a number to continue. Type 4 to exit the Employee Menu");
                                EmployeeMenuinput = int.Parse(Console.ReadLine());


                                switch(EmployeeMenuinput)
                                {
                                    case 1: //Check in employee
                                        {
                                            Console.WriteLine("\nPlease check in with your name:");
                                            //Read name
                                            string nameIn = Console.ReadLine();
                                            Console.WriteLine("\nWhat is your mood today?");
                                            Console.WriteLine("Type 1 if you're happy, type 2 if you're neutral and type 3 if you're sad");
                                            //Read mood
                                            int moodIn = int.Parse(Console.ReadLine());
                                            Employee employee = new Employee(nameIn);
                                            employee.CheckIn(nameIn, moodIn);

                                            break;
                                        }
                                    case 2: //Check out employee
                                        {
                                            Console.WriteLine("\nPlease check out with your name:");
                                            //Read name
                                            string nameIn = Console.ReadLine();
                                            Employee employee = new Employee(nameIn);
                                            employee.CheckOut(nameIn);

                                            break;
                                        }
                                    case 3://Register new employee
                                        {
                                            Console.WriteLine("\nPlease enter the name of the employee: ");
                                            //Read name
                                            string nameIn = Console.ReadLine();

                                            Console.WriteLine("\nPlease enter the position of the employee");
                                            //Read position
                                            string positionIn = Console.ReadLine();

                                            Console.WriteLine("\nPleace enter the team of the employee");
                                            //Read team
                                            string teamIn = Console.ReadLine();

                                            //Save employee
                                            Employee employee = new Employee(nameIn, positionIn, teamIn);
                                            employee.SaveEmployee();

                                            break;
                                        }                                   
                                }
                            }
                            while (EmployeeMenuinput != 4);

                            break;
                        }
                    case 2: //Go to Guest Menu
                        {
                            int GuestMenuInput = 0;
                            do
                            {
                                //Guest Menu
                                Console.Clear();
                                Console.WriteLine("Welcome to the Guest Menu");
                                Console.WriteLine("Do you want to:");
                                Console.WriteLine("1: Register new guest");
                                Console.WriteLine("2: Arrival");
                                Console.WriteLine("3: Departure");

                                //register user input
                                Console.WriteLine("\nPlease enter a number to continue. Type 4 to exit the Guest Menu");

                                GuestMenuInput = int.Parse(Console.ReadLine());

                                switch (GuestMenuInput)
                                {
                                    case 1: //Register new guest
                                        {
                                            Console.WriteLine("\nRegister a guest:");
                                            Console.WriteLine("\nDate of visit: ('dd,MM,yyyy') ex: (7, 10, 2021)");
                                            //Read date
                                            var date = Console.ReadLine();

                                            Console.WriteLine("\nName of guest");
                                            //Read name
                                            string name = Console.ReadLine();

                                            Console.WriteLine("\nCompany");
                                            //Read company
                                            string company = Console.ReadLine();

                                            Console.WriteLine("\nResponsible for visit");
                                            //Read reaponsible for visit
                                            string responsibleForVisitor = Console.ReadLine();

                                            Console.WriteLine("Does the guest need to recieve a saftey brochure? (Y/N)");
                                            //register safety brochure
                                            string safetyBrochureIn = Console.ReadLine();
                                            bool safetyBrochureReceived = true;
                                            if (safetyBrochureIn == "Y" || safetyBrochureIn == "y") { safetyBrochureReceived = true; }
                                            else if (safetyBrochureIn == "N" || safetyBrochureIn == "n") { safetyBrochureReceived = false; }

                                            //Save new guest
                                            Guest guest = new Guest(DateTime.Parse(date), name, company, responsibleForVisitor, safetyBrochureReceived);
                                            guest.SaveGuest();

                                            break;
                                        }
                                    case 2: //Check in guest
                                        {
                                            Console.WriteLine("\nPlease resgister your arrival by entering your full name:");
                                            //Read name and register arrival
                                            Guest guest = new Guest(Console.ReadLine());
                                            guest.RegisterArrival();

                                            break;
                                        }
                                    case 3: //Check out guest
                                        {
                                            Console.WriteLine("\nPlease register your departure by entering your full name:");
                                            //Read name and regsiter depature
                                            Guest guest = new Guest(Console.ReadLine());
                                            guest.RegisterDepature();

                                            break;
                                        }
                                }                               
                            }
                            while (GuestMenuInput != 4);

                            break;
                        }
                    case 3: //Go to Booking menu
                        {
                            int BookingMenuInput = 0;
                            do
                            {
                                //Booking menu
                                Console.Clear();
                                Console.WriteLine("Welcome to the Hydac booking system");
                                Console.WriteLine("1: Register new room");
                                Console.WriteLine("2: Booking");
                                Console.WriteLine("3: View Bookings");

                                //Register use input
                                Console.WriteLine("\nPlease enter a number to continue. Type 4 to exit the Booking Menu");

                                BookingMenuInput = int.Parse(Console.ReadLine());

                                switch (BookingMenuInput)
                                {
                                    case 1: //Register new room
                                        {
                                            Console.WriteLine("\nRegister new room:");
                                            Console.WriteLine("Enter the name of the room");
                                            //Read name
                                            string name = Console.ReadLine();

                                            Console.WriteLine("\nEnter the location of the room");
                                            //Read location
                                            string location = Console.ReadLine();

                                            //Save meeting room
                                            MeetingRoom meetingRoom = new MeetingRoom(name, location);
                                            meetingRoom.SaveRoom();
                                            break;
                                        }
                                    case 2: //Create booking
                                        {
                                            //Show bookings
                                            Console.WriteLine("Meeting rooms:");
                                            StreamReader RoomReader = new StreamReader("SaveMeetingRoom.txt");
                                            while (RoomReader.EndOfStream == false)
                                            {
                                                Console.WriteLine(RoomReader.ReadLine());
                                            }

                                            Console.WriteLine("\nPlease enter your name:");
                                            //Read employee
                                            string employee = Console.ReadLine();

                                            Console.WriteLine("\nPlease choose a room");
                                            //Read name
                                            string name = Console.ReadLine();

                                            Console.WriteLine("\nPlease choose a date and time for the booking ('MM/dd/yyyy HH:mm') ex: ('7/10/2021 12:15')");
                                            //Read date
                                            string date = Console.ReadLine();                                           

                                            //Save booking
                                            Booking booking = new Booking(employee, name, DateTime.Parse(date));
                                            booking.SaveBooking();
                                            break;
                                        }
                                    case 3: //View booking
                                        {
                                            //Show bookings
                                            Console.WriteLine("Bookings:");
                                            StreamReader RoomReader = new StreamReader("SaveMeetingRoom.txt");
                                            while (RoomReader.EndOfStream == false)
                                            {
                                                Console.WriteLine(RoomReader.ReadLine());
                                            }
                                            Console.ReadLine();
                                            break;
                                        }
                                }
                            }
                            while (BookingMenuInput != 4);
                            break;
                        }
                }
            }
            while (MainMenuInput != 4);                       
        }
    }
}
