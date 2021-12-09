using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyVaccineInventory.Models
{
    public class Patient
    {
        [Display(Name = "Patient Id")]
        public long Id { get; set; }
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        [Display(Name = "Phone Number")]
        public long phone { get; set; }
        [Display(Name = "Gender")]
        public string gender { get; set; }

    }
}
