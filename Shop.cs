using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest3_Link1
{
    internal class Shop
    {
        public void addProduct(List<Product> ProductList)
        {
            Console.Write("Nhap ten san pham: ");
            string name = Console.ReadLine();
            Console.Write("Nhap gia san pham: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Nhap mo ta san pham: ");
            string des = Console.ReadLine();
            Console.Write("Nhap danh gia san pham: ");
            int rate = int.Parse(Console.ReadLine());
            int[] r = new int[] { };
            if (rate >= 1 && rate <= 5)
            {
                for (int i = 0; i < r.Length; i++)
                {
                    r[i] = rate;
                }
            }
            Product product = new Product(name, des, price, r);
            ProductList.Add(product);
            Console.WriteLine("Them 1 san pham thanh cong!");
        }

        public void removeProduct(List<Product> ProductList)
        {
            Console.Write("Nhap ten san pham: ");
            string name = Console.ReadLine();
            foreach (Product p in ProductList)
            {
                if (p.Name.Equals(name))
                {
                    ProductList.Remove(p);
                    Console.WriteLine("Da xoa san pham!");
                }
                else
                {
                    Console.WriteLine("Khong ton tai san pham nay!");
                }
            }
        }
        public void iterateProductList(List<Product> ProductList)
        {
            foreach (Product product in ProductList)
            {
                int count = 0;
                int sum = 0;
                double rate;
                for (int i = 0; i < product.Rate.Length; i++)
                {
                    sum += product.Rate[i];
                    count++;
                }
                rate = sum / count;
                product.viewInfo();
                Console.WriteLine("Rating: {0}", rate);
                Console.WriteLine("---------------------------");
            }
        }
        public void searchProduct(List<Product> ProductList)
        {
            Console.Write("Nhap so thu nhat: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int n2 = int.Parse(Console.ReadLine());
            foreach (Product p in ProductList)
            {
                if (p.Price >= n1 && p.Price <= n2)
                {
                    p.viewInfo();
                    Console.WriteLine("---------------------------");
                }
                else
                {
                    Console.WriteLine("Khong co san pham tim duoc");
                }
            }
        }

        public void sortProduct(List<Product> ProductList)
        {
            List<Product> sort = ProductList.OrderBy(x => x.Price).ToList();
            foreach (Product product in sort)
            {
                product.viewInfo();
                Console.WriteLine("---------------------------");
            }
        }
    }
}
