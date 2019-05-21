﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_DependencyInjection_IoC.Models
{
    public class SecondProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public SecondProductRepository()
        {
            products.Add(new Product()
            {
                Id = 1,
                Name = "GameBoy",
                Category = "Electronics",
                Price = 599.99M
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Laptop",
                Category = "Electronics",
                Price = 199.99M
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Tablet",
                Category = "Electronics",
                Price = 1099.99M
            });

        }

        public Product Add(Product item)
        {
            if (item is null)
            {
                throw new ArgumentNullException("item cannot be null.");
            }

            products.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            products.RemoveAll(p => p.Id == id);
            return true;
        }

        public Product Get(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return products.AsEnumerable();
        }

        public bool Update(Product item)
        {
            if (item is null)
            {
                throw new ArgumentNullException("item cannot be null");
            }

            int index = products.FindIndex(p => p.Id == item.Id);

            if (index == -1)
            {
                return false;
            }

            products.RemoveAt(index);
            products.Add(item);
            return true;

        }
    }
}