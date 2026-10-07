using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuppShop.Models
{
    public class CustomerM
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Number { get; set; } = null!;

        public string Password { get; set; } = null!;

        [InverseProperty(nameof(OrderM.Customer))]
        public ICollection<OrderM> Order { get; set; } = null!;
    }
}
