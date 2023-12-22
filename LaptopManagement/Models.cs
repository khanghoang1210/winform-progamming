using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopManagement
{
    public class Laptop
    {
        private String _laptopID;
        private String _laptopName;
        private String _laptopType;
        private DateTime _productDate;
        private String _processor;
        private int _HDD;
        private int _RAM;
        private int _price;
        private String _imageName;

        public Laptop()
        {
        }

        public Laptop(string laptopID, string laptopName, string laptopType, DateTime productDate, string processor, int hDD, int rAM, int price, string imageName)
        {
            _laptopID = laptopID;
            _laptopName = laptopName;
            _laptopType = laptopType;
            _productDate = productDate;
            _processor = processor;
            _HDD = hDD;
            _RAM = rAM;
            _price = price;
            _imageName = imageName;
        }

        public string LaptopID { get => _laptopID; set => _laptopID = value; }
        public string LaptopName { get => _laptopName; set => _laptopName = value; }
        public string LaptopType { get => _laptopType; set => _laptopType = value; }
        public DateTime ProductDate { get => _productDate; set => _productDate = value; }
        public string Processor { get => _processor; set => _processor = value; }
        public int HDD { get => _HDD; set => _HDD = value; }
        public int RAM { get => _RAM; set => _RAM = value; }
        public int Price { get => _price; set => _price = value; }
        public string ImageName { get => _imageName; set => _imageName = value; }
    }

}
