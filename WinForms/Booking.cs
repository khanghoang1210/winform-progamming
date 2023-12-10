using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;

namespace AirlineBookingApp
{
    public partial class Booking : Form
    {
        const double AdultCost = 1;
        const double ChildCost = 0.8;
        const double InfantCost = 0.5;
        public User currentUser;
        public Customer currentCustomer;
        Login ParentForm;
        public int idxBooking;
        List<Flight> flights = new List<Flight>
        {
            new Flight("FL001", DateTime.Now.AddHours(1), DateTime.Now.AddHours(2), "Domestic", "CityA", "CityB", 2000000),
            new Flight("FL002", DateTime.Now.AddHours(3), DateTime.Now.AddHours(4), "International", "CityC", "CityD", 5000000),
            // Add more flights as needed
        };
        List<string> seatClasses = new List<string>
        {
            "Economy",
            "Premium Economy",
            "Business",
            "First Class"
        };
        public Booking()
        {
            InitializeComponent();
            BindingSource dts = new BindingSource();
            dts.DataSource = typeof(Flight);
            dataGridView1.DataSource = dts;
            dts.Add(flights[0]);
            dts.Add(flights[1]);
            comboBox1.DataSource = seatClasses;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void lblTotalCost(object sender, EventArgs e)
        {

        }

        private void Adult_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }
        private void UpdateTotalCost()
        {
            Flight selectedFlight = (Flight)dataGridView1.CurrentRow.DataBoundItem;
            string total = (double.Parse(Adult.Value.ToString()) * AdultCost * selectedFlight.Price +
                double.Parse(Child.Value.ToString()) * ChildCost * selectedFlight.Price +
                double.Parse(Infant.Value.ToString()) * InfantCost * selectedFlight.Price).ToString();
            string totalFormatted = int.Parse(total).ToString("##,##", new NumberFormatInfo() { NumberGroupSeparator = "," });
            lblTotal.Text = $"{totalFormatted} VND";
        }

        private void Child_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void Infant_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Flight selectedFlight = (Flight)dataGridView1.CurrentRow.DataBoundItem;
            MessageBox.Show($"You has successful booked!\nYour booking information:\nFlight Id: {selectedFlight.FlightID}\nSeat class: {comboBox1.SelectedValue}\nTotal Cost: {lblTotal.Text}", "Confirm booking");
        }
        private void SetCurrentUser(User user)
        {
            currentUser = user;
            currentCustomer = ParentForm.CustomerList.Find(x => x.CustomerName == currentUser.UserName);
        }
    }
}
