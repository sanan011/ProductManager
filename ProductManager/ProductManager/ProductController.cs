using ProductManager;
using System;

namespace ProductManager
{
    public class ProductController
    {
        private Product product;

        public ProductController()
        {
            product = new Product();
        }

        public void AddProduct(string brand, string model, decimal price, int quantity, ProductCategory category)
        {
            product.Add(brand, model, price, quantity, category);
        }

        public void ShowAllProducts()
        {
            product.ShowAllProducts();
        }

        public void RemoveProduct(int index)
        {
            product.RemoveProduct(index);
        }

        public void UpdateProduct(int index, string brand, string model, decimal price, int quantity, ProductCategory category)
        {
            product.UpdateProduct(index, brand, model, price, quantity, category);
        }

        public void UpdateProductByProperty(int productId, int propertyId, string newValue)
        {
            product.UpdateProductByProperty(productId, propertyId, newValue);
        }
    }
}
