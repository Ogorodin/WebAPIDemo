using DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    interface IProductService
    {
        public IEnumerable<Product> GetProducts();

        public Product GetProductById(int id);

        public bool AddProduct(Product product);

        public bool UpdateProduct(Product product);

        public bool DeleteProductById(int id);

    }
}
