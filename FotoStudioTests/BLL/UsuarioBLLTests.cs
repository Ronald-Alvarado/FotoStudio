using FotoStudio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotoStudio.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuario usuarios = new Usuario();

            usuarios.UsuarioId = 0;
            usuarios.Nombres = "Frandy";
            usuarios.NombreUsuario = "Admin";
            usuarios.Contrasena = "Addmin";
            usuarios.Email = "Frandy@gmail.com";

            Assert.IsTrue(UsuarioBLL.Guardar(usuarios));
        }


        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = UsuarioBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuario usuarios;
            usuarios = UsuarioBLL.Buscar(1);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var usuarios = new List<Usuario>();
            usuarios = UsuarioBLL.GetList(c => true);
            Assert.IsNotNull(usuarios);
        }


    }
}