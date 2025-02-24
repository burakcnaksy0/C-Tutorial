using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampı_301.EntityLayer.Concrete
{
    public class Order
    {

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int Quantity { get; set; }   // kaç adet sattığı

        public decimal UnitPrice { get; set; }
        
        public decimal TotalPrice { get; set; }
    }
}
