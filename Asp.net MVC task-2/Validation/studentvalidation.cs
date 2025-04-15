using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.net_MVC_task_2.Validation
{
	public class studentvalidation:ValidationAttribute
	{
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime DateOfBirth;
            try
            {
                DateOfBirth = Convert.ToDateTime(value); 
            }
            catch (Exception)
            {
                return new ValidationResult("Invalid date format.");
            }

            DateTime today = DateTime.Today;
            DateTime minAllowedDate = today.AddYears(-60); 
            DateTime maxAllowedDate = today.AddYears(-18); 

            if (DateOfBirth < minAllowedDate || DateOfBirth > maxAllowedDate)
            {
                return new ValidationResult("Invalid Date of Birth. Age must be between 18 and 60.");
            }

            return ValidationResult.Success;
        }


    }


}