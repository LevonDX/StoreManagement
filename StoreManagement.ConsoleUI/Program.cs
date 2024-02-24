using StoreManagement.Data.Abstracts;
using StoreManagement.Data.Concrete;
using StoreManagement.Data.Entities;

namespace StoreManagement.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using IProductRepository productRepository = new ProductRepository();

            productRepository.AddProduct(new Product
            {
                Name = "Product 1",
                Description = "Description 1",
                UnitPrice = 100,

                Category = new Category
                {
                    Name = "Category 1",
                    Description = "Description 1"
                }
            });

            productRepository.AddProduct(new Product
            {
                Name = "Product 2",
                Description = "Description 2",
                UnitPrice = 200,

                Category = new Category
                {
                    Name = "Category 2",
                    Description = "Description 2"
                }
            });

            productRepository.AddProduct(new Product
            {
                Name = "Product 3",
                Description = "Description 3",
                UnitPrice = 300,

                Category = new Category
                {
                    Name = "Category 3",
                    Description = "Description 3"
                }
            });

            productRepository.SaveChanges();
        }
    }
}