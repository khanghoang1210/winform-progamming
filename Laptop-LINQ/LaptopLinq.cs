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
        string excelFilePath = projectPath + "\\Data\\LaptopList.xlsx";
        string connectionString =
            "Data Source=LAPTOP-0COSK050\\SQLEXPRESS01;Initial Catalog=Laptop_Management; Integrated Security=SSPI";
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
            dgvLaptop.DataSource = dts;
            dgvLaptop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //public int ReadDataFromFile(List<Laptop> DataList, string FilePath, int colCount)
        //{
        //    excel.Application xlApp = new excel.Application();
        //    excel.Workbook xlWorkBook = xlApp.Workbooks.Open(FilePath);
        //    excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
        //    excel.Range xlRange = xlWorkSheet.UsedRange;
        //    xlWorkSheet.Columns.ClearFormats();
        //    xlWorkSheet.Rows.ClearFormats();
        //    int rowCount = xlWorkSheet.UsedRange.Rows.Count;
        //    int numLap = 0;
        //    string LaptopID = "";
        //    string LaptopName = "";
        //    string LaptopType = "";
        //    DateTime ProductDate = DateTime.Now;
        //    string Processor = "";
        //    int HDD = 0;
        //    int RAM = 0;
        //    int Price = 0;
        //    string imageName = "";

        //    for (int i = 2; i <= rowCount; i++)
        //    {
        //        for (int j = 1; j <= colCount; j++)
        //        {
        //            switch (j)
        //            {
        //                case 1:
        //                    LaptopID = xlRange.Cells[i, j].Value2.ToString(); break;
        //                case 2:
        //                    LaptopName = xlRange.Cells[i, j].Value2.ToString(); break;
        //                case 3:
        //                    LaptopType = xlRange.Cells[i, j].Value2.ToString(); break;
        //                case 4:
        //                    string prod = xlRange.Cells[i, j].Value2.ToString();
        //                    ProductDate = DateTime.ParseExact(prod,
        //                                                   "dd/MM/yyyy", CultureInfo.InvariantCulture); break;
        //                case 5:
        //                    Processor = xlRange.Cells[i, j].Value2.ToString(); break;
        //                case 6:
        //                    HDD = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString()); break;
        //                case 7:
        //                    RAM = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString()); break;
        //                case 8:
        //                    Price = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString()); break;
        //                    //case 9:
        //                    //imageName = xlRange.Cells[i, j].Value2.ToString(); break;
        //            }
        //        }
        //        DataList.Add(new Laptop());
        //        DataList[numLap].LaptopID = LaptopID;
        //        DataList[numLap].LaptopName = LaptopName;
        //        DataList[numLap].LaptopType = LaptopType;
        //        DataList[numLap].ProductDate = ProductDate;
        //        DataList[numLap].Processor = Processor;
        //        DataList[numLap].HDD = HDD;
        //        DataList[numLap].RAM = RAM;
        //        DataList[numLap].Price = Price;
        //        DataList[numLap].ImageName = imageName;
        //        numLap++;
        //    }
        //    xlApp.Quit();
        //    MessageBox.Show("Load Data From Excel Successful: " + (rowCount - 1).ToString() + " Records");
        //    return (rowCount - 1);
        //}
        public int ReadDataFromSQLServer(List<Laptop> DataList, string connectionString)
        {
            SqlConnection conn;
            conn = new SqlConnection(connectionString);
            int iRow = 0;
            int numRecords = 0;
            try
            {
                conn.Open();
                Console.WriteLine("Connection is open");

                string SqlString = @"Select LaptopID,
                                    LaptopName,
                                    LaptopType,
                                    ProductDate = Convert(varchar(10), CONVERT(date,ProductDate,106),103),
                                    Processor,
                                    HDD,RAM,Price,ImageName
                                    From dbo.LaptopInfo";
                using (var command = new SqlCommand(SqlString, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            laptops.Add(new Laptop());
                            laptops[iRow].LaptopID = reader.GetString(0);
                            laptops[iRow].LaptopName = reader.GetString(1);
                            laptops[iRow].LaptopType = reader.GetString(2);
                            laptops[iRow].ProductDate = DateTime.ParseExact(reader.GetString(3), "dd/MM/yyyy",
                                CultureInfo.InvariantCulture);
                            laptops[iRow].Processor = reader.GetString(4);
                            laptops[iRow].HDD = reader.GetInt32(5);
                            laptops[iRow].RAM = reader.GetInt32(6);
                            laptops[iRow].Price = reader.GetInt32(7);
                            laptops[iRow].ImageName = reader.GetString(8);
                            iRow++;
                        }
                    }
                }
                SqlCommand cmd = new SqlCommand("Select count(*) from LaptopInfo", conn);
                object result = cmd.ExecuteScalar();
                numRecords = int.Parse(result.ToString());
                MessageBox.Show("Load Data From SQL is complete: " + numRecords.ToString() + " Records");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection: " + ex.Message);

            }
            return numRecords;
        }
        private void btnSql_Click(object sender, EventArgs e)
        {
            loadData = 2;
            dataTable = new DataTable();
            laptops.Clear();
            int numDataRow = ReadDataFromSQLServer(laptops, connectionString);
            List<Laptop> subList = laptops.Select(x => new Laptop_LINQ.Laptop()
            {
                LaptopID = x.LaptopID,
                LaptopName = x.LaptopName,
                LaptopType = x.LaptopType,
                ProductDate = x.ProductDate,
                Processor = x.Processor,
                HDD = x.HDD,
                RAM = x.RAM,
                Price = x.Price
            }).ToList();

            foreach (var bi in subList)
            {
                dts.Add(bi);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop();
            laptop.LaptopID = "NA";
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

            laptops.Add(AddEdit.selectedLaptop);
            dts.Add(AddEdit.selectedLaptop);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLaptop.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvLaptop.SelectedRows[0];
                AddEdit.selectedLaptop = (Laptop)row.DataBoundItem;
                AddEdit.isEdit = true;
                AddEdit addForm = new AddEdit();

                addForm.ShowDialog();
                for (int i = 0; i < laptops.Count; i++)
                {
                    if (laptops[i].LaptopID == AddEdit.selectedLaptop.LaptopID)
                    {
                        laptops[i] = AddEdit.selectedLaptop;
                        dts[i] = AddEdit.selectedLaptop;
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLaptop.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvLaptop.SelectedRows[0];
                Laptop laptop = (Laptop)row.DataBoundItem;
                string question = "Do you want to delete laptop:" + laptop.LaptopID;
                DialogResult result = MessageBox.Show(question, "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < laptops.Count; i++)
                    {
                        if (laptops[i].LaptopID == laptop.LaptopID)
                        {
                            laptops.RemoveAt(i);
                            dts.RemoveAt(i);
                            MessageBox.Show("Delete successful.");

                        }
                    }

                }
            }

        }
        private void DisplayData()
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (dgvLaptop.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvLaptop.SelectedRows[0];
                AddEdit.selectedLaptop = (Laptop)row.DataBoundItem;
                AddEdit.isEdit = true;
                AddEdit addForm = new AddEdit();

                addForm.ShowDialog();
                for (int i = 0; i < laptops.Count; i++)
                {
                    if (laptops[i].LaptopID == AddEdit.selectedLaptop.LaptopID)
                    {
                        laptops[i] = AddEdit.selectedLaptop;
                        dts[i] = AddEdit.selectedLaptop;
                    }
                }
            }
        }
    }
}
