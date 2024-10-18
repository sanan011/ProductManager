using ProductManager;
using System;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductController controller = new ProductController();

            controller.AddProduct("Apple", "Macbook Pro", 2000, 4, ProductCategory.PC);
            controller.AddProduct("Lenovo", "Legion", 3000, 5, ProductCategory.PC);

            controller.ShowAllProducts();

            controller.RemoveProduct(1);
            controller.ShowAllProducts();

            controller.UpdateProduct(2, "Lenovo", "Legion Pro", 3200, 6, ProductCategory.PC);
            controller.ShowAllProducts();

            controller.UpdateProductByProperty(2, 1, "Asus");
            controller.ShowAllProducts();

            Console.ReadLine();
        }
    }
}
