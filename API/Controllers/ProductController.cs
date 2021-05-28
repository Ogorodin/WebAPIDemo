using API.Services;
using DataLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService service)
        {
            _productService = service;
        }

        // get all
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        // get by ID
        [HttpGet]
        [Route("{id}")]
        public Product GetProductById(int id)
        {
            return _productService.GetProductById(id);
        }

        // add product
        [HttpPost]
        public bool AddProduct(Product product)
        {
            return _productService.AddProduct(product);
        }

        // update product
        [HttpPut]
        [Route("{id}")]
        public bool UpdateProduct(Product product)
        {
            return _productService.UpdateProduct(product);
        }

        // delete product
        [HttpDelete]
        [Route("{id}")]
        public bool DeleteProductById(int id)
        {
            return _productService.DeleteProductById(id);
        }

    }
}
