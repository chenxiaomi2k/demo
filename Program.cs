using ProgressTest3_Link1;
using System.Collections.Generic;

int menu()
{
    Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");
    Console.WriteLine("1. Add new product");
    Console.WriteLine("2. Remove product");
    Console.WriteLine("3. Iterate product list");
    Console.WriteLine("4. Search product");
    Console.WriteLine("5. Sort product by price");
    Console.WriteLine("6. Exit");
    while (true)
    {
        Console.Write("Enter option: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= 6)
        {
            return choice;
        }
        else
        {
            Console.WriteLine("Not a choice");
        }
    }
}
List<Product> ProductList = new List<Product>();
Shop s = new Shop();
while (true)
{
    int choice = menu();
    Console.WriteLine();
    switch (choice)
    {
        case 1:
            s.addProduct(ProductList);
            break;
        case 2:
            s.removeProduct(ProductList);
            break;
        case 3:
            s.iterateProductList(ProductList);
            break;
        case 4:
            s.searchProduct(ProductList);
            break;
        case 5:
            s.sortProduct(ProductList);
            break;
        default:
            return;
    }
}