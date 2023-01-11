using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link1
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int[] Rate { get; set; }

        public Product()
        {
        }

        public Product(string name, string description, double price, int[] rate)
        {
            Name = name;
            Description = description;
            Price = price;
            Rate = rate;
        }

        public void viewInfo()
        {
            Console.WriteLine("Product name: "+ Name);
            Console.WriteLine("Product Price: " + Price);
            Console.WriteLine("Product description: " + Description);
        }
    }
}
