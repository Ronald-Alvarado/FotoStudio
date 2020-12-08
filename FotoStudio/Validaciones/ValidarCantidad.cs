using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FotoStudio.Validaciones
{
    public class ValidarCantidad : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                decimal cantidad = Convert.ToDecimal(value);

                if (cantidad >= 1)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Debe agregar una Cantidad");

            }
            return new ValidationResult("Debe agregar una Cantidad");
        }
    }
}
