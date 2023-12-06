using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class Flight
    {
        public string FlightID { get; set; }
        public DateTime TimeDepart { get; set; }
        public DateTime TimeArrival { get; set; }
        public string FlightType { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public Flight()
        {
            FlightID = "Not Assigned";
        }
        public Flight(string flightID, DateTime timeDepart, DateTime timeArrival, string flightType, string fromLocation, string toLocation)
        {
            FlightID = flightID;
            TimeDepart = timeDepart;
            TimeArrival = timeArrival;
            FlightType = flightType;
            FromLocation = fromLocation;
            ToLocation = toLocation;
        }
    }
}
