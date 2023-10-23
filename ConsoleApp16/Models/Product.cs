using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Models
{
    internal class Product
    {
        public int Count;
        public int Price;
        public Product()
        {


        }
        public void SetPrice(int price)
        {
            if(price <0) {
                Console.WriteLine("Notebookun qiymeti 0-dan kicik ola bilmez");
            }
            else
            {
                Console.WriteLine("Notebook qiymeti: " + price);
            }
            
        }
    }
}
