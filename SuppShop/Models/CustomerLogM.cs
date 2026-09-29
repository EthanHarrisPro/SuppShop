using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuppShop.Models
{
    public class CustomerLogM
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
