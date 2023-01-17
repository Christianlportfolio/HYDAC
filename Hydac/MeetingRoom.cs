using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hydac
{
    public class MeetingRoom
    {

        public string Name { get; set; }
        public string Location { get; set; }

        public MeetingRoom() { }

        public MeetingRoom(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public string MeetingRoomTitle()
        {
            return "[Lokalenavn: " + Name + "] [Lokation: " + Location + "]";
        }

        public void SaveRoom()
        {
            StreamWriter meetingRoomWriter;
            meetingRoomWriter = new StreamWriter("SaveBooking.txt", true);

            meetingRoomWriter.WriteLine(MeetingRoomTitle());

            meetingRoomWriter.Close();
        }


    }
}
