using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCare.Models
{
    
    public class contact
    {
        
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter FirstName..")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter LastName..")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        
        [Required(ErrorMessage = "Please Enter Phone number..")]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Email...")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Message...")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
