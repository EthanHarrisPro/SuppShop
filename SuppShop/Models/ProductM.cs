using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuppShop.Models
{
    public class ProductM
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int Stock { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }



    }
}
