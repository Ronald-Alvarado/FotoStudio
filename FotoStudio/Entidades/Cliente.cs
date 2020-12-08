using FotoStudio.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FotoStudio.Entidades
{
    public class Cliente
    {
        [Key] [ValidarId] public int ClienteId { get; set; }

        [Range(1, 100000, ErrorMessage = "Este campo debe tener un rango mayor a 0.")]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [ValidarNombre] public string Nombres { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [ValidarApellidos] public string Apellidos { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [ValidarCedula] public string Cedula { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [ValidarTelefono] public string Telefono { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [ValidarTelefono] public string Celular { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }


        public Cliente()
        {
            ClienteId = 0;
            UsuarioId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Sexo = string.Empty;
            FechaNacimiento = DateTime.Now;

        }
    }
}
