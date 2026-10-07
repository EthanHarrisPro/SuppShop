using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuppShop.Models
{
    public class BasketDetailsM
    {
        public int ID { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }


        public int Quantity { get; set; }

        [ForeignKey(nameof(Basket))]
        public int BasketId { get; set; }


        public ProductM Product { get; set; } = null!;

        public BasketM Basket { get; set; } = null!;

        



    }
}
