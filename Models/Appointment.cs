using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyVaccineInventory.Models
{
    public class Appointment
    {
        [Display(Name = "Appointment Id")]
        public int ApptId { get; set; }
        [Display(Name = "Patient Id")]
        public int PatientId { get; set; }
        [Display(Name = "Vaccinator Id")]
        public int VaccinatorId { get; set; }
        [Display(Name = "Vaccine Id")]
        public int VaccineId { get; set; }
        [Display(Name = "Appointment Date")]
        public DateTime ApptDate { get; set; }

    }
}
