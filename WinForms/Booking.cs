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
            new Flight("FL001", DateTime.Now.AddHours(1), DateTime.Now.AddHours(2), "Vietjet Air", "CityA", "CityB", 2000000),
            new Flight("FL002", DateTime.Now.AddHours(3), DateTime.Now.AddHours(4), "Bamboo Airways", "CityC", "CityD", 5000000),
            new Flight("FL003", DateTime.Now.AddHours(4), DateTime.Now.AddHours(5), "Vietnam Airline", "CityE", "CityF", 7000000),
            new Flight("FL004", DateTime.Now.AddHours(3), DateTime.Now.AddHours(4), "Vietjet Air", "CityG", "CityH", 3000000),
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
            ParentForm = Login.OriginalForm;
            dts.DataSource = typeof(Flight);
            dataGridView1.DataSource = dts;
            dts.Add(flights[0]);
            dts.Add(flights[1]);
            dts.Add(flights[2]);
            dts.Add(flights[3]);
            comboBox1.DataSource = seatClasses;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateTotalCost();
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
            string totalFormatted;
            totalFormatted = int.Parse(total).ToString("##,##", new NumberFormatInfo() { NumberGroupSeparator = "," });
            if (String.IsNullOrEmpty(totalFormatted))
            {
                lblTotal.Text = "0 VND";
            }
            else
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
            string total = lblTotal.Text;
            if (total == "0 VND")
            {
                MessageBox.Show("Please select your passenger quantity", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show($"You has successful booked!\nYour booking information:\n" +
                $"Flight Id: {selectedFlight.FlightID}\nSeat class: {comboBox1.SelectedValue}\n" +
                $"Total Cost: {total}", "Confirm booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.ResetLogin = true;
            ParentForm.Show();
        }
    }
}
