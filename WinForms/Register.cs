using AirlineBookingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Register : Form
    {
        string startupPath;
        string avatarPath;
        Login ParentForm;
        public Register()
        {

            InitializeComponent();
            startupPath = Login.OriginalForm.startUpPath;
            ParentForm = Login.OriginalForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Find Avatar Image";
            openFileDialog.Filter = "JPG file|*.jpg";
            openFileDialog.InitialDirectory = startupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatarPath = openFileDialog.FileName;
                picAvatar.Image = Image.FromFile(avatarPath);
                startupPath = Path.GetDirectoryName(avatarPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnRegiser_Click(object sender, EventArgs e)
        {
            User user = new User();
            Customer customer = new Customer();
            if (txtUserName.Text.Trim().Length == 0 ||
                txtPassword.Text.Trim().Length == 0 ||
                txtFullname.Text.Trim().Length == 0)
            {
                MessageBox.Show("User name, Password and Full name are not blank", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password are not matched", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            User SpecificOne = ParentForm.UserList.Find(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text);
            if (SpecificOne != null)
            {
                MessageBox.Show("User name is exsisted", "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.CustomerID = txtFullname.Text;

            customer.CustomerID = txtUserName.Text;
            customer.CustomerName = txtFullname.Text;
            customer.Password = txtPassword.Text;
            customer.BirthDay = dateDOB.Value;
            customer.Avatar = picAvatar.Image;
            customer.Nationality = txtNation.Text;
            customer.PassPortNbr = txtPassport.Text;
            ParentForm.UserList.Add(user);
            ParentForm.CustomerList.Add(customer);

            MessageBox.Show("Register successful.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
