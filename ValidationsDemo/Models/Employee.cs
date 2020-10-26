using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationsDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "First name is required")]
        [PrajwalValidation(ErrorMessage = "Name must include Prajwal")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Email id is required")]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 100,ErrorMessage = "Age should be more than 18 years.")]
        public int Age { get; set; }
    }
}