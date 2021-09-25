using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with Query Expressions * ****\n");
            // Этот массив будет основой для тестирования. . .
            ProductInfo[] itemsInStock = new[] 
            {
                new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberlnStock = 24},
                new ProductInfo{Name = "Milk Maid Milk", Description = "Milk cow's love", NumberlnStock = 100},
                new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberlnStock = 120}, 
                new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberlnStock = 2},
                new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberlnStock = 100},
                new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza'", NumberlnStock = 73}
            };
            SelectEverything(itemsInStock);
            Console.WriteLine();
            ListProductNames(itemsInStock);
            Console.ReadLine();
        }
        static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("All product details");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }
        static void ListProductNames(ProductInfo[] products)
        {
            // Теперь получить только наименования товаров.
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;
            foreach (var n in names)
            {
                Console.WriteLine("Name: {0}", n);
            }
        }
    }

    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = ""; 
        public int NumberlnStock { get; set; } = 0;
        public override string ToString() => $"Name = {Name}, Descnption = {Description}, Number in Stock = {NumberlnStock}";
    }
}
