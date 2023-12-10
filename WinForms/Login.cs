
using AirlineBookingApp;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinForms
{
    public partial class Login : Form
    {
        public static Login OriginalForm;
        public List<Customer> CustomerList;
        public List<User> UserList;
        public string startUpPath;
        public bool ResetLogin;

        public Login()
        {
            InitializeComponent();
            OriginalForm = this;
            startUpPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            CustomerList = new List<Customer>();
            UserList = new List<User>();
            UserList.Add(new User("CS001", "admin", "admin123"));
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
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter pass word", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }
            User SpecificOne = UserList.Find(x => (x.UserName == txtUserName.Text) && (x.Password == txtPassword.Text));
            if (SpecificOne == null)
            {
                MessageBox.Show("User name or Password is not matched", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtPassword.Text = "";
                txtPassword.Focus();
            }
            if (SpecificOne != null)
            {
                Booking bookingWindow = new Booking();
                this.Hide();
                bookingWindow.ShowDialog();
                this.Show();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerWindow = new Register();
            this.Hide();
            registerWindow.ShowDialog();
            this.Show();
        }

        private void textUserName(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}