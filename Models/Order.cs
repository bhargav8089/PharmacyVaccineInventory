using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyVaccineInventory.Models
{
    public class Order
    {
        [Display(Name = "Order Id")]
        public int OrderId { get; set; }
        [Display(Name = "ManufacturerId")]
        public int ManufacturerId { get; set; }
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        [Display(Name = "Shipped Date")]
        public DateTime ShippedDate { get; set; }
        [Display(Name = "Delivery Date")]
        public DateTime DeliveryDate { get; set; }
        [Display(Name = "Delivery Status")]
        public string DeliveryStatus { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

    }
}
