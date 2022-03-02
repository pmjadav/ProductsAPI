using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsAPI.Models
{
    public class Product
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
        public string prodCategory { get; set; }
        public decimal prodPrice { get; set; }
    }
}