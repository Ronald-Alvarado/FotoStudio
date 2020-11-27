﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FotoStudio.Entidades
{
    public class Usuario
    {
        [Key] public int UsuarioId { get; set; }

        public string Nombres { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Contrasena { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [EmailAddress]
        public string Email { get; set; }


        public Usuario()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
            Email = string.Empty;
        }

        public Usuario(int usuarioId, string nombres, string nombreUsuario, string contrasena, string email)
        {
            UsuarioId = usuarioId;
            Nombres = nombres;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Email = email;
        }
    }
}