using Mvc_DependencyInjection_IoC.DataModels;
using Mvc_DependencyInjection_IoC.DataModels.Interfaces;
using System.Collections.Generic;

namespace Mvc_DependencyInjection_IoC.Data.EF.Models.Repositories
{
    public class ProductRepositoryDb : IProductRepository
    {
        private ProductsDbContext context = new ProductsDbContext();
        public Product Add(Product item)
        {
            context.Products.Add(item);
            context.SaveChanges();
            return item;
        }

        public bool Delete(int id)
        {
            var product = context.Products.Find(id);

            if (product is null)
            {
                return false;
            }

            context.Products.Remove(product);
            context.SaveChanges();
            return true;
        }

        public Product Get(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products;
        }

        public bool Update(Product item)
        {
            var currentProduct = context.Products.Find(item.Id);

            if (currentProduct is null)
            {
                return false;
            }

            currentProduct = item;
            context.SaveChanges();
            return true;
        }
    }
}
