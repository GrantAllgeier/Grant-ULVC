using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace UniversityofLouisvilleVaccine.Models
{
    public class Vaccine
    {
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Vaccine ID")]
        public string vaccineID { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Vaccine Name")]
        public string vaccineName { get; set; }

        [Required]
        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateReceived { get; set; }

        [Required]
        [Display(Name = "CPT")]
        public string CPT { get; set; }

        [Required]
        [Display(Name = "ICD-9 Code")]
        public string ICD9Code { get; set; }

        [Required]
        [Display(Name = "NDC")]
        public string NDC { get; set; }

        [Required]
        [Display(Name = "Lead Time")]
        public int leadTime { get; set; }

        [Required]
        [Display(Name = "Lot Number")]
        public string lotNumber { get; set; }

        [Required]
        [Display(Name = "Number of Doses")]
        public int numofDoses { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int salesPrice { get; set; }

    }

    public class VaccineDBContext : DbContext
    {
        public DbSet<Vaccine> Vaccines { get; set; }
    }

}