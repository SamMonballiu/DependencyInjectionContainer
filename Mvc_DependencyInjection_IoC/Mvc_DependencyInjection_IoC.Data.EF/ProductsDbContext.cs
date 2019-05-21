namespace Mvc_DependencyInjection_IoC.Data.EF
{
    using Mvc_DependencyInjection_IoC.Data.EF.Models;
    using Mvc_DependencyInjection_IoC.DataModels;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext()
            : base("name=Default")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}