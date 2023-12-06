using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;

namespace AirlineBookingApp
{
    public partial class Booking : Form
    {
        List<Flight> flights = new List<Flight>
        {
            new Flight("FL001", DateTime.Now.AddHours(1), DateTime.Now.AddHours(2), "Domestic", "CityA", "CityB"),
            new Flight("FL002", DateTime.Now.AddHours(3), DateTime.Now.AddHours(4), "International", "CityC", "CityD"),
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

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
