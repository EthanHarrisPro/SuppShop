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

        public decimal Total { get; set; }

        public int ProductId { get; set; }

        public CustomerM Customer { get; set; } = null!;
        public ICollection<OrderDetailsM> orderDetails { get; set; } = null!;
    }
}
