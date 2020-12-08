using Microsoft.VisualStudio.TestTools.UnitTesting;
using FotoStudio.BLL;
using FotoStudio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotoStudio.BLL.Tests
{
    [TestClass()]
    public class FotografosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {

            Fotografos fotografos = new Fotografos();
            fotografos.FotografoId = 0;
            fotografos.UsuarioId = 1;
            fotografos.Nombres = "Frandy";
            fotografos.Apellidos = "Mota";
            fotografos.Cedula = "41223355889";
            fotografos.Direccion = "Cotui";
            fotografos.Telefono = "8093527799";
            fotografos.Celular = "8092458037";
            fotografos.Sexo = "Hombre";
            fotografos.Sueldo = 100;

            Assert.IsTrue(FotografosBLL.Guardar(fotografos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = FotografosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Fotografos fotografos;
            fotografos = FotografosBLL.Buscar(1);
            Assert.IsNotNull(fotografos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Fotografos>();
            lista = FotografosBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}