using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Digital.Utilities.Validations
{
    public class MakeMeUpperCase : ValidationAttribute
    {
        string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("Is emptyy!");
            return input.First().ToString();
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            try
            {
                validationContext.ObjectType.GetProperty(validationContext.DisplayName)
                .SetValue(validationContext.ObjectInstance, null);
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
