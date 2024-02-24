using StoreManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Data.Abstracts
{
    public interface IProductRepository : IDisposable 
    {
        void AddProduct(Product product);
        Task AddProductAsync(Product product);

        void UpdateProduct(Product product);
        Task UpdateProductAsync(Product product);

        void DeleteProduct(int productId);
        Task DeleteProductAsync(int productId);

        Product? GetProductById(int productId);

        IQueryable<Product> GetAllProducts();

        void SaveChanges();
    }
}
