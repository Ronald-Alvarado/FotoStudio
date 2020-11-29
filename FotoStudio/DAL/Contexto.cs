using FotoStudio.BLL;
using FotoStudio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FotoStudio.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fotografos> Fotografos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compras> Compras { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= Data/FotoStudio.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario { 
                            UsuarioId = 1, 
                            Nombres = "Administrador", 
                            NombreUsuario = "admin", 
                            Contrasena = UsuarioBLL.Encriptar("admin"), 
                            Email = "Adminis@example.com" });
        }


    }
}
