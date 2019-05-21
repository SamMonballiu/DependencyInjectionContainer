﻿using System.Collections.Generic;
using Mvc_DependencyInjection_IoC.DataModels;

namespace Mvc_DependencyInjection_IoC.Data.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        bool Update(Product item);
        bool Delete(int id);
    }
}
