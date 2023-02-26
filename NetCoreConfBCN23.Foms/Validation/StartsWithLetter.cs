using System.ComponentModel.DataAnnotations;

namespace NetCoreConfBCN23.Foms.Validation
{
    public class StartsWithLetter : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var strValue = (string)value;
            //return (!String.IsNullOrEmpty(strValue) && Char.IsLetter(strValue[0])) ? ValidationResult.Success : new ValidationResult($"The {validationContext.DisplayName} field doesn't starts with letter.");
            return new ValidationResult($"The {validationContext.DisplayName} field doesn't starts with letter.");
        }
    }
}
