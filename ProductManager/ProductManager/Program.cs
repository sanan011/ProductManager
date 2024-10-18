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


            Console.ReadLine();
        }
    }
}
