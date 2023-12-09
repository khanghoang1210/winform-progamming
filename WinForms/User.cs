using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PassPortNbr { get; set; }
        public string Password { get; set; }
        public string Nationality { get; set; }
        public Image Avatar { get; set; }
        public Customer()
        {
            CustomerID = "Not Assigned";
        }
        public Customer(string customerID, string customerName, DateTime birthDay, string passPortNbr, string password, string nationality, Image avatar)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            BirthDay = birthDay;
            PassPortNbr = passPortNbr;
            Password = password;
            Nationality = nationality;
            Avatar = avatar;
        }
    }

    public class User
    {
        public string CustomerID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User()
        {

        }
        public User(string customerID, string userName, string password)
        {
            CustomerID = customerID;
            UserName = userName;
            Password = password;
        }
    }
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
