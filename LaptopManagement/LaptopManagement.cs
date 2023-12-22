using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
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
        DataTable dataTable = new DataTable();
        int currentLapIndex = -1;

        public LaptopManagement()
        {
            InitializeComponent();
            dgvLaptop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaptop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvLaptop.AllowUserToOrderColumns = true;
            dgvLaptop.AllowUserToResizeColumns = true;
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

            MessageBox.Show(subList[2].RAM.ToString());
            foreach (var bi in subList)
            {
                dts.Add(bi);
            }
            //dts.AllowNew = true;
            //dts.DataSource = dataTable;
            //dgvLaptop.AutoGenerateColumns = false;
            //dgvLaptop.DataSource = dts;
            //dts.Add(new Laptop("1", "Laptop1", "Type1", DateTime.Now, "Processor1", 500, 8, 1000, "Image1.jpg"));
            //dts.Add(new Laptop("2", "Laptop2", "Type2", DateTime.Now, "Processor2", 1000, 16, 1500, "Image2.jpg"));
            //dts.Add(new Laptop("3", "Laptop3", "Type3", DateTime.Now, "Processor3", 750, 12, 1200, "Image3.jpg"));
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

        private void DgvLaptop_SelectionChanged(object sender, EventArgs e)
        {
            if (laptops.Count == 0 || dataTable.Rows.Count == 0) return;
            currentLapIndex = dgvLaptop.CurrentRow.Index;
        }

    }

}