using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Models
{
    internal class Notebook:Product
    {
        private string _brand;
        private string _model;
        private int _ram;
        private int _storage;
       
         


        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Sisteme daxil etmek olmaz!!!");
                }
            }
        }

        public int Ram
        {
            get { return _ram; }
            set
            {
                if (value > 0 && value < 128)
                {
                    _ram = value;
                }
                else
                {
                    Console.WriteLine("RAM 0-dan boyuk 128-den kicik olmalidir");
                }
            }
        }

        public int Storage
        {
            get { return _storage; }
            set
            {
                if (value > 0)
                {
                    _storage = value;
                }
                else
                {
                    Console.WriteLine("Guc 0-dan kicik ola bilmez");
                }

            }
        }













    }
}
