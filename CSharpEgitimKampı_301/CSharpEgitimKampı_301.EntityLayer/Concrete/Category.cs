using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampı_301.EntityLayer.Concrete
{
    public class Category
    {
        // tablo --> query
        // class --> table
        // properties --> columns

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    
        public bool CategoryStatus { get; set; }

        public string CategoryDescription { get; set; }

        public List<Product> Products { get; set; }   // bir categoride birden fazla ürün olabilir
    }
}
/*
 field / variable / property

. int x ;  --> field

. public int y { get; set;}  --> property

. void test(){   --> variable
     int z;
}
 */