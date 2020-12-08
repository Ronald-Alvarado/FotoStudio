using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FotoStudio.Validaciones
{
    public class ValidarCosto : ValidationAttribute
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
                    return new ValidationResult("El costo debe ser un número");
                }

                if (cantidad >= 1m)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Debe agregar un costo");

            }
            return new ValidationResult("Debe agregar un costo");
        }
    }
}