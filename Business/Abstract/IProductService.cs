﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAll();
        List<Product> GetProductsByProductName(string productName);
        List<Product> GetProductsByCategory(int categoryId);

    }
}
