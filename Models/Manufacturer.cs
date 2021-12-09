using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyVaccineInventory.Models
{
    public class Manufacturer
    {
        [Display(Name = "Maker Id")]
        public int MakerId { get; set; }
        [Display(Name = "Maker Name")]
        public string MakerName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Vaccine Name")]
        public string VaccineName { get; set; }
        [Display(Name = "Cost")]
        public float Cost { get; set; }

    }
}
