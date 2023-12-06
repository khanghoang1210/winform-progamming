
using AirlineBookingApp;

namespace WinForms
{
    public partial class Login : Form
    {
        public static Login OriginalForm;
        public List<User> CustomerList;

        public Login()
        {
            InitializeComponent();
            OriginalForm = this;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking bookingWindow = new Booking();
            this.Hide();
            bookingWindow.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerWindow = new Register();
            this.Hide();
            registerWindow.ShowDialog();
            this.Show();
        }
    }
}