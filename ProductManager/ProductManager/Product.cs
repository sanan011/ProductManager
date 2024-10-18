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
            products.Add(new ArrayList() { brand, model, price, quantity, category });
        }

        public ArrayList GetAllProducts()
        {
            return products;
        }

        public void ShowAllProducts()
        {
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
            products.RemoveAt(index - 1);
        }

        public void UpdateProduct(int index, string brand, string model, decimal price, int quantity, ProductCategory category)
        {
            products[index - 1] = new ArrayList() { brand, model, price, quantity, category };
        }

        public void UpdateProductByProperty(int productId, int propertyId, string newValue)
        {
            ArrayList product = (ArrayList)products[productId - 1];
            var oldValue = product[propertyId - 1];

            if (oldValue is string)
            {
                product[propertyId - 1] = newValue;
            }
            else if (oldValue is decimal)
            {
                product[propertyId - 1] = Convert.ToDecimal(newValue);
            }
            else if (oldValue is int)
            {
                product[propertyId - 1] = Convert.ToInt32(newValue);
            }
        }
    }
}
