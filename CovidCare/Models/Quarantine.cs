using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCare.Models
{
    public class Quarantine
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Full Name")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Column(TypeName = "int")]
        [Required(ErrorMessage = "Age is required.")]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Choose the City First.")]
        [DisplayName("City")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Choose the Quarantine Centres.")]
        [DisplayName("Quarantine Centres")]
        public string Centres { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Number of Beds Required.")]
        [DisplayName("Number of Beds")]
        public string Beds { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Aadhar Card number is required.")]
        [DisplayName("Aadhar Card Number")]
        public string Aadhar { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Mobile Number")]
        public string Mobile { get; set; }
    }
}

