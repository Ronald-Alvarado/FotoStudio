using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FotoStudio.Validaciones
{
    public class ValidarPrecio : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                decimal cantidad = 0;
                try
                {
                    cantidad = Convert.ToDecimal(value);
                }
                catch
                {
                    return new ValidationResult("El precio debe ser un número");
                }

                if (cantidad >= 1)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("El precio no puede ser 0");

            }
            return new ValidationResult("Debes poner un precio");
        }
    }
}