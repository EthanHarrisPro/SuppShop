using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuppShop.Models
{
    public class StaffLogM
    {
        [Key]
        public int StaffId { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public StaffM Staff { get; set; } = null!;
    }
}
