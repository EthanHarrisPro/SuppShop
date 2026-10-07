using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuppShop.Models
{
    public class OrderM
    {
        [Key]
        public int Id { get; set; }

        public int BasketId { get; set; }

        public int CustomerId { get; set; }

        public BasketM Basket { get; set; } = null!;

        public CustomerM Customer { get; set; } = null!;
    }
}
