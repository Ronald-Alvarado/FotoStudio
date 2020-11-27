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
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Categoria> Categoria { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= Data/FotoStudio.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioId = 1, Nombres = "Administrador", NombreUsuario = "Admin", Contrasena = UsuarioBLL.Encriptar("Admin"), Email = "ericksvicente@hotmail.com" });
        }


    }
}
