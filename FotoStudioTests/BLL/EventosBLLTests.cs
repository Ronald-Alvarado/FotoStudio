using Microsoft.VisualStudio.TestTools.UnitTesting;
using FotoStudio.BLL;
using FotoStudio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotoStudio.BLL.Tests
{
    [TestClass()]
    public class EventosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {

            Eventos eventos = new Eventos();
            eventos.EventoId = 0;
            eventos.UsuarioId = 1;
            eventos.FotografoId = 1;
            eventos.Descripcion = "Cumpleanos";
            eventos.Lugar = "SFM";
            eventos.FechaInicio = DateTime.Now;
            eventos.FechaFin = DateTime.Now;
            eventos.Precio = 100;


            Assert.IsTrue(EventosBLL.Guardar(eventos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = EventosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Eventos eventos;
            eventos = EventosBLL.Buscar(2);
            Assert.IsNotNull(eventos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Eventos>();
            lista = EventosBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }


    }
}