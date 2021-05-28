using DataLayer.Entity;
using System.Collections.Generic;

namespace DataLayer.Repository
{
    interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public bool AddProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProductById(int id);
    }
}
