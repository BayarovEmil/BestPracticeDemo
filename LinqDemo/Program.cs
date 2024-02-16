using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Program
    {
       public static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Komputer"},
                new Category{CategoryId=2, CategoryName="Telefon" },
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32Ram",UnitPrice=2000,UnitsInStock=5 },
                new Product{ProductId = 2,CategoryId=1,ProductName="Lenova Laptop",QuantityPerUnit="16Ram",UnitPrice=1245,UnitsInStock=6 },
                new Product{ProductId = 3,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="12Ram",UnitPrice=1450,UnitsInStock=6 },
                new Product{ProductId = 4,CategoryId=2,ProductName="Samsung A23",QuantityPerUnit="6Ram",UnitPrice=600,UnitsInStock=50 },
                new Product{ProductId = 5,CategoryId=2,ProductName="Iphone Xp",QuantityPerUnit="16Ram",UnitPrice=1500,UnitsInStock=5 }
            };

            Console.WriteLine("Alqoritm------------->");
            foreach (var product in products)
            {
                if (product.UnitPrice >= 1000)
                {
                    Console.WriteLine(product.ProductName);
                }
                
            }

            Console.WriteLine("Linq------------->");
            List<Product> result = products.Where(p => p.UnitPrice >= 1400 && p.UnitsInStock>3).ToList();
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            GetProducts(products);
            GetProductsLinq(products);
            Console.ReadLine();
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filter = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice>1300 && product.UnitsInStock>3)
                {
                    filter.Add(product);
                }
            }
            return filter;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p=>p.UnitPrice >1300 && p.UnitsInStock>3).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
