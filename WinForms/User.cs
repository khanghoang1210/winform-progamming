using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class User
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PassPortNbr { get; set; }
        public string Password { get; set; }
        public string Nationality { get; set; }
        public Image Avatar { get; set; }
        public User()
        {
            CustomerID = "Not Assigned";
        }
        public User(string customerID, string customerName, DateTime birthDay, string passPortNbr, string password, string nationality, Image avatar)
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

}
