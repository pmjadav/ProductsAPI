using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { prodId = 1, prodName = "Rice", prodCategory = "Groceries", prodPrice = 1400 },
            new Product { prodId = 2, prodName = "Speaker", prodCategory = "Electronics", prodPrice = 1800},
            new Product { prodId = 3, prodName = "Juice", prodCategory = "Groceries", prodPrice = 150},
            new Product { prodId = 4, prodName = "Butter", prodCategory = "Dairy Products", prodPrice = 370},
            new Product { prodId = 5, prodName = "Milkr", prodCategory = "Dairy Products", prodPrice = 370}
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var prod = products.FirstOrDefault((p) => p.prodId == id);
            if (prod == null) 
            {
                return NotFound();
            }                
            return Ok(prod);
        }
    }
}
