using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class Program
    {
        static void Main(string[] args)
        {
            //class çağırma
            Product product1 = new Product();
            product1.ID = 1;
            product1.ProductName = "Masa";
            //2-Mboilya
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;
            //bu şekilde de oluşturulur 
            Product product2 = new Product { ID = 2, CategoryId = 5, UnitInStock = 5, ProductName="Kalem", UnitPrice=35 };
                
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        
        }
    }
}
