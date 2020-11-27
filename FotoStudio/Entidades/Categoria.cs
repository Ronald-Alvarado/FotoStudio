using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FotoStudio.Entidades
{
    public class Categoria
    {
        [Key] public int CategoriaId { get; set; }

        [Range(minimum: 1, maximum: 200000000, ErrorMessage = "El rango de este campo debe ser mayor a 0.")]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public Categoria()
        {
            CategoriaId = 0;
            UsuarioId = 0;
            Nombre = string.Empty;
        }
    }
}
