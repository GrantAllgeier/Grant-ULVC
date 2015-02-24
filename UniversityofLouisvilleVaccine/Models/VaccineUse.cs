using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityofLouisvilleVaccine.Models
{
    public class VaccineUse
    {
        [Required]
        [Display(Name = "Vaccine Use ID")]
        public string vaccineUseID { get; set; }

        [Required]
        [Display(Name = "Vaccine ID")]
        public string vaccineID { get; set; }

        [Required]
        [Display(Name = "Patient ID")]
        public string patientID { get; set; }

        [Required]
        [Display(Name = "Injection Site")]
        public string injectionSite { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        
    }

    public class VaccineUseDBContext : DbContext
    {
        public DbSet<Vaccine> VaccineUses { get; set; }
    }



}