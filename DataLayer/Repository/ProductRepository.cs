using DataLayer.Entity;
using DataLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    class ProductRepository : IProductRepository
    {
        private DataAccess _db;

        public ProductRepository()
        {

        }
        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductById(int id)
        {
            throw new NotImplementedException();
        }





    }
}
