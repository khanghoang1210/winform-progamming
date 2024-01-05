using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using excel = Microsoft.Office.Interop.Excel;

namespace Laptop_LINQ
{
    public partial class LaptopLinq : Form
    {
        public List<Laptop> laptops = new List<Laptop>();
        public int loadData = 0;
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //string excelFilePath = projectPath + "\\Data\\LaptopList.xlsx";
        string connectionString =
            "Data Source=LAPTOP-0COSK050\\SQLEXPRESS01;Initial Catalog=Laptop_Management; Integrated Security=SSPI";
        LaptopDBDataContext db = new LaptopDBDataContext();
        DataTable dataTable = new DataTable();
        BindingSource dts = new BindingSource();
        public LaptopLinq()
        {
            InitializeComponent();
            dgvLaptop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaptop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvLaptop.AllowUserToOrderColumns = true;
            dgvLaptop.AllowUserToResizeColumns = true;

            dts.DataSource = typeof(LaptopLinq);
            //dgvLaptop.DataSource = dts;
            dgvLaptop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DisplayData()
        {
            dgvLaptop.DataSource = db.LaptopInfos.ToList();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            LaptopInfo checkedLatop = new LaptopInfo();
            List<LaptopInfo> laptopList = db.LaptopInfos.Where(x => x.LaptopID.Contains("LAP")).ToList();
            string newID = "LAP";
            if (laptopList.Count == 0)
            {
                newID += "001";
            }
            else
            {
                checkedLatop = laptopList.Last();
                newID += generateKey(checkedLatop.LaptopID.Substring(checkedLatop.LaptopID.Length - 3));
            }
            LaptopInfo laptop = new LaptopInfo();

            laptop.LaptopID = newID;
            laptop.LaptopName = "NA";
            laptop.LaptopType = "NA";
            laptop.ProductDate = DateTime.ParseExact("11/11/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            laptop.Processor = "NA";
            laptop.HDD = 0;
            laptop.RAM = 0;
            laptop.Price = 0;
            laptop.ImageName = "laptop.jpg";

            AddEdit.selectedLaptop = laptop;
            AddEdit.isEdit = false;
            AddEdit addForm = new AddEdit();

            addForm.ShowDialog();

            db.LaptopInfos.InsertOnSubmit(laptop);
            db.SubmitChanges();
            DisplayData();
        }

        private void btnSql_Click_1(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvLaptop.SelectedRows.Count != 0)
            {
                string laptopIDSelect = this.dgvLaptop.SelectedRows[0].Cells[0].Value.ToString();
                LaptopInfo updatedLaptop = db.LaptopInfos.Where(x => x.LaptopID == laptopIDSelect).FirstOrDefault();
                DataGridViewRow row = this.dgvLaptop.SelectedRows[0];
                AddEdit.selectedLaptop = (LaptopInfo)row.DataBoundItem;

                AddEdit.isEdit = true;
                AddEdit addForm = new AddEdit();

                addForm.ShowDialog();
                updatedLaptop = AddEdit.selectedLaptop;
                db.SubmitChanges();
                DisplayData();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string laptopIDSelect = this.dgvLaptop.SelectedRows[0].Cells[0].Value.ToString();
            LaptopInfo deletedLaptop = db.LaptopInfos.Where(x => x.LaptopID == laptopIDSelect).FirstOrDefault();
            string question = "Do you want to delete laptop:" + deletedLaptop.LaptopID;
            DialogResult result = MessageBox.Show(question, "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.LaptopInfos.DeleteOnSubmit(deletedLaptop);
                db.SubmitChanges();
            }
            DisplayData();
        }
        public string generateKey(string currentID)
        {
            int i = 0;
            if (int.TryParse(currentID, out i))
            {
                i++;
                return i.ToString().PadLeft(3, '0');
            }
            throw new Exception("Non-numeric string passed as argument");
        }
    }
}
