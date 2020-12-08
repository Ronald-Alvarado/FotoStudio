using Microsoft.VisualStudio.TestTools.UnitTesting;
using FotoStudio.BLL;
using FotoStudio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotoStudio.BLL.Tests
{
    [TestClass()]
    public class VentasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {

            Venta ventas = new Venta();
            ventas.VentaId = 0;
            ventas.ClienteId = 1;
            ventas.Nombres = "Frandy";
            ventas.Apellidos = "Mota";
            ventas.Total = 100;

            Assert.IsTrue(VentaBLL.Guardar(ventas));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Venta ventas;
            ventas = VentaBLL.Buscar(2);
            Assert.IsNotNull(ventas);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = VentaBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Venta>();
            lista = VentaBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}