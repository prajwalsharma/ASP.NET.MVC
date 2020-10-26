using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationsDemo.Models
{
    public class PrajwalValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string input = value.ToString();
                if (input.Contains("Prajwal"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    ErrorMessage = ErrorMessage ?? "Field must contain Prajwal";
                }
            }
            
            return new ValidationResult(ErrorMessage);
        }
    }
}