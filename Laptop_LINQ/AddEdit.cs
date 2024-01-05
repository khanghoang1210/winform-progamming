using Laptop_LINQ;
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

namespace Laptop_LINQ
{
    public partial class AddEdit : Form
    {
        static public LaptopInfo selectedLaptop;
        static public bool isEdit;
        LaptopDBDataContext db = new LaptopDBDataContext();
        public AddEdit()
        {
            InitializeComponent();
            if (isEdit)
            {
                btnAdd.Text = "Edit";
                lbTitle.Text = "Edit Laptop";
                txtName.Text = selectedLaptop.LaptopName;
                cbType.Text = selectedLaptop.LaptopType;
                dpDate.Value = selectedLaptop.ProductDate;
                txtProcessor.Text = selectedLaptop.Processor;
                cbHdd.Text = selectedLaptop.HDD.ToString();
                cbRam.Text = selectedLaptop.RAM.ToString();
                txtPrice.Text = selectedLaptop.Price.ToString();
                lbImgName.Text = selectedLaptop.ImageName;
            }
            else
            {
                lbTitle.Text = "Add Laptop";
                btnAdd.Text = "Add";
            }
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            selectedLaptop.LaptopName = txtName.Text;
            selectedLaptop.LaptopType = cbType.Text;
            selectedLaptop.ProductDate = dpDate.Value;
            selectedLaptop.Processor = txtProcessor.Text;
            selectedLaptop.HDD = int.Parse(cbHdd.Text);
            selectedLaptop.RAM = int.Parse(cbRam.Text);
            selectedLaptop.Price = int.Parse(txtPrice.Text);
            selectedLaptop.ImageName = lbImgName.Text;
            MessageBox.Show(isEdit ? "Edit successful." : "Add successful.");
            this.Close();
        }
    }
}
