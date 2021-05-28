using DataLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : Controller
    {
        // get all
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        // get by ID
        [HttpGet]
        [Route("{id}")]
        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        // add product
        [HttpPost]
        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        // update product
        [HttpPut]
        [Route("{id}")]
        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        // delete product
        [HttpDelete]
        [Route("{id}")]
        public bool DeleteProductById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
