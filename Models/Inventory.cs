using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyVaccineInventory.Models
{
    public class Inventory
    {
        [Display(Name = "Vaccine Id")]
        public int VaccineId { get; set; }
        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate { get; set; }
        [Display(Name = "Is Used")]
        public bool IsUsed { get; set; }
    }
}
