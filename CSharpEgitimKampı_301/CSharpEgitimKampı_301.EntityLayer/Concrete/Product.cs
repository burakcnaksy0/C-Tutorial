﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampı_301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductStock { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductDescription { get; set; }

        public int CustomerId { get; set; }  // her ürünün bir kategorisi vardır.

        public virtual Category Category{ get; set; }

        public List<Order> Orders { get; set; }
    }
}
