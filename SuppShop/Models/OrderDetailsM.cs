using System;
using System.Collections.Generic;
using System.Text;

namespace SuppShop.Models
{
    public class OrderDetailsM
    {
        public int ID { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public OrderM Order { get; set; } = null!;

        public ProductM Product { get; set; } = null!;



    }
}
