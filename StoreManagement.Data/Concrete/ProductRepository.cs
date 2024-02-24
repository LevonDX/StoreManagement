using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using StoreManagement.Data.Abstracts;
using StoreManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Data.Concrete
{
    //public class ProductRepository : IProductRepository
    //{
    //    public void AddProduct(Product product)
    //    {
    //        using (var context = new StoreDbContext())
    //        {
    //            context.Products.Add(product);
    //            context.SaveChanges();
    //        }
    //    }

    //    public async Task AddProductAsync(Product product)
    //    {
    //        using StoreDbContext context = new StoreDbContext();

    //        await context.Products.AddAsync(product);

    //        await context.SaveChangesAsync();
    //    }

    //    public void DeleteProduct(int productId)
    //    {
    //        using StoreDbContext context = new StoreDbContext();
    //        Product? product = context.Products.Find(productId);

    //        if (product == null)
    //        {
    //            return;
    //        }

    //        context.Products.Remove(product);
    //        context.SaveChanges();
    //    }

    //    public async Task DeleteProductAsync(int productId)
    //    {
    //        using StoreDbContext context = new StoreDbContext();
    //        Product? product = context.Products.Find(productId);

    //        if (product != null)
    //        {
    //            context.Products.Remove(product);
    //            await context.SaveChangesAsync();
    //        }
    //    }

    //    public IQueryable<Product> GetAllProducts()
    //    {
    //        using StoreDbContext context = new StoreDbContext();
    //        return context.Products.AsQueryable();
    //    }


    //    public Product? GetProductById(int productId)
    //    {
    //        using StoreDbContext context = new StoreDbContext();
    //        return context.Products.Find(productId);
    //    }

    //    public void UpdateProduct(Product product)
    //    {
    //        using StoreDbContext context = new StoreDbContext();
    //        context.Products.Update(product);
    //        context.SaveChanges();
    //    }

    //    public async Task UpdateProductAsync(Product product)
    //    {
    //        using StoreDbContext context = new StoreDbContext();
    //        context.Products.Update(product);

    //        await context.SaveChangesAsync();
    //    }

    //}
}
