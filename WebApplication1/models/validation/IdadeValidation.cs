using System.ComponentModel.DataAnnotations;

namespace WebApplication1.models.validation
{
    public class IdadeValidation: ValidationAttribute

    {
        public override bool IsValid(object? value)
        {
            int valor = Convert.ToInt32(value);
            if (valor <18)
            {
                return false;
            }
            return true;
        }
    }
}
