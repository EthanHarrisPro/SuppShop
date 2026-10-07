using SuppShop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuppShop.Models
{
    public class BasketM
    {
        [Key]
        public int Id { get; set; }

        public int BasketDetailsId { get; set; }

        [InverseProperty(nameof(BasketDetailsM.Basket))]
        public ICollection<BasketDetailsM> BasketDetails { get; set; } = null!;
    }
}
