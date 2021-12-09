using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyVaccineInventory.Models
{
    public class Employee
    {
        [Display(Name = "Employee Id")]
        public long EmployeeId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Role")]
        public string Role { get; set; }
    }
}
