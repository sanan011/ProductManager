using ProductManager;
using System;
using System.Collections;

namespace ProductManager
{
    public class Product
    {
        string brand, model;
        decimal price;
        int quantity;
        ProductCategory category;
        ArrayList products;

        public Product()
        {
            products = new ArrayList();
        }

        public void Add(string brand, string model, decimal price, int quantity, ProductCategory category)
        {
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model))
            {
                Console.WriteLine("Error: Brand or model cannot be empty.");
                return;
            }

            if (price <= 0)
            {
                Console.WriteLine("Error: Price must be greater than zero.");
                return;
            }

            if (quantity < 0)
            {
                Console.WriteLine("Error: Quantity cannot be negative.");
                return;
            }

            products.Add(new ArrayList() { brand, model, price, quantity, category });
        }

        public ArrayList GetAllProducts()
        {
            return products;
        }

        public void ShowAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            int counter = 1;
            foreach (var allProduct in products)
            {
                Console.WriteLine($"PRODUCT {counter}:");
                foreach (var item in (ArrayList)allProduct)
                {
                    Console.WriteLine(item);
                }
                counter++;
            }
        }

        public void RemoveProduct(int index)
        {
            if (index < 1 || index > products.Count)
            {
                Console.WriteLine("Error: Invalid product index.");
                return;
            }

            products.RemoveAt(index - 1);
            Console.WriteLine($"Product {index} removed successfully.");
        }

        public void UpdateProduct(int index, string brand, string model, decimal price, int quantity, ProductCategory category)
        {
            if (index < 1 || index > products.Count)
            {
                Console.WriteLine("Error: Invalid product index.");
                return;
            }

            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model))
            {
                Console.WriteLine("Error: Brand or model cannot be empty.");
                return;
            }

            if (price <= 0)
            {
                Console.WriteLine("Error: Price must be greater than zero.");
                return;
            }

            if (quantity < 0)
            {
                Console.WriteLine("Error: Quantity cannot be negative.");
                return;
            }

            products[index - 1] = new ArrayList() { brand, model, price, quantity, category };
            Console.WriteLine($"Product {index} updated successfully.");
        }

        public void UpdateProductByProperty(int productId, int propertyId, string newValue)
        {
            if (productId < 1 || productId > products.Count)
            {
                Console.WriteLine("Error: Invalid product ID.");
                return;
            }

            ArrayList product = (ArrayList)products[productId - 1];
            var oldValue = product[propertyId - 1];

            if (oldValue is string && !string.IsNullOrWhiteSpace(newValue))
            {
                product[propertyId - 1] = newValue;
            }
            else if (oldValue is decimal && decimal.TryParse(newValue, out decimal newDecimal))
            {
                product[propertyId - 1] = newDecimal;
            }
            else if (oldValue is int && int.TryParse(newValue, out int newInt))
            {
                product[propertyId - 1] = newInt;
            }
            else
            {
                Console.WriteLine("Error: Invalid value for the specified property.");
                return;
            }

            Console.WriteLine($"Product {productId} property {propertyId} updated successfully.");
        }
    }
}
