using System.ComponentModel.DataAnnotations;

namespace NetCoreConfBCN23.Foms.Validation
{
    public class StartsWithLetter : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            return (!String.IsNullOrEmpty((string)value) && Char.IsLetter(((string)value)[0])) 
                ? ValidationResult.Success 
                : new ValidationResult($"The {validationContext.DisplayName} field doesn't starts with letter.");
        }
    }
}
