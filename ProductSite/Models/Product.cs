using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSite.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Derscription { get; set; }
        public int Price { get; set; }
    }
}