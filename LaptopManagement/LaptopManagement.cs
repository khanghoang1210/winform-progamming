using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace LaptopManagement
{
    public partial class LaptopManagement : Form
    {
        public List<Laptop> laptops = new List<Laptop>();
        public int loadData = 0;
        static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string excelFilePath = projectPath + "\\Data\\LaptopList.xlsx";
        string connectionString =
            "Data Source=LAPTOP-0COSK050\\SQLEXPRESS01;Initial Catalog=Laptop_Management; Integrated Security=SSPI";
        DataTable dataTable = new DataTable();
        int currentLapIndex = -1;

        public LaptopManagement()
        {
            InitializeComponent();
            dgvLaptop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaptop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvLaptop.AllowUserToOrderColumns = true;
            dgvLaptop.AllowUserToResizeColumns = true;

        }

        public int ReadDataFromFile(List<Laptop> DataList, string FilePath, int colCount)
        {
            excel.Application xlApp = new excel.Application();
            excel.Workbook xlWorkBook = xlApp.Workbooks.Open(FilePath);
            excel._Worksheet xlWorkSheet = xlWorkBook.Sheets[1];
            excel.Range xlRange = xlWorkSheet.UsedRange;
            xlWorkSheet.Columns.ClearFormats();
            xlWorkSheet.Rows.ClearFormats();
            int rowCount = xlWorkSheet.UsedRange.Rows.Count;
            int numLap = 0;
            string LaptopID = "";
            string LaptopName = "";
            string LaptopType = "";
            DateTime ProductDate = DateTime.Now;
            string Processor = "";
            int HDD = 0;
            int RAM = 0;
            int Price = 0;
            string imageName = "";

            for (int i = 2; i < rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    switch (j)
                    {
                        case 1:
                            LaptopID = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 2:
                            LaptopName = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 3:
                            LaptopType = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 4:
                            string prod = xlRange.Cells[i, j].Value2.ToString();
                            ProductDate = DateTime.ParseExact(prod,
                                                           "dd/MM/yyyy", CultureInfo.InvariantCulture); break;
                        case 5:
                            Processor = xlRange.Cells[i, j].Value2.ToString(); break;
                        case 6:
                            HDD = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString()); break;
                        case 7:
                            RAM = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString()); break;
                        case 8:
                            Price = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString()); break;
                        case 9:
                            imageName = xlRange.Cells[i, j].Value2.ToString(); break;
                    }
                }
                DataList.Add(new Laptop());
                DataList[numLap].LaptopID = LaptopID;
                DataList[numLap].LaptopName = LaptopName;
                DataList[numLap].LaptopType = LaptopType;
                DataList[numLap].ProductDate = ProductDate;
                DataList[numLap].Processor = Processor;
                DataList[numLap].HDD = HDD;
                DataList[numLap].RAM = RAM;
                DataList[numLap].Price = Price;
                DataList[numLap].ImageName = imageName;
                numLap++;
            }
            xlApp.Quit();
            MessageBox.Show("Load Data From Excel Successful: " + (rowCount - 1).ToString() + " Records");
            return (rowCount - 1);
        }
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
        private void btnExcel_Click(object sender, EventArgs e)
        {
            loadData = 1;
            BindingSource dts = new BindingSource();
            dts.DataSource = typeof(Laptop);
            dgvLaptop.DataSource = dts;
            int colCount = 11;
            int NumDatarow = ReadDataFromFile(laptops, excelFilePath, colCount);
            List<Laptop> subList = laptops.Select(x => new Laptop()
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

        private void btnSql_Click(object sender, EventArgs e)
        {
            loadData = 2;
            dataTable = new DataTable();
            laptops.Clear();
            int numDataRow = ReadDataFromSQLServer(laptops, connectionString);
            List<Laptop> subList = laptops.Select(x => new Laptop()
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

            BindingSource dts = new BindingSource();
            dts.DataSource = typeof(Laptop);
            dgvLaptop.DataSource = dts;
            foreach (var bi in subList)
            {
                dts.Add(bi);
            }
        }
        private void dgvLaptop_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


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
            BindingSource dts = new BindingSource();
            dts.DataSource = typeof(Laptop);
            dgvLaptop.DataSource = dts;
            dts.Add(laptop);
            MessageBox.Show("Add successful.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}