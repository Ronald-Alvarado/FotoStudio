using FotoStudio.BLL;
using FotoStudio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotoStudio.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulos = new Articulos
            {
                ArticuloId = 0,
                UsuarioId = 1,
                CategoriaId = 1,
                Descripcion = "Taza Personalizada",
                Stock = 0,
                Precio = 150,
                Costo = 0
            };
            paso = ArticulosBLL.Guardar(articulos);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = ArticulosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Articulos articulos;
            articulos = ArticulosBLL.Buscar(1);

            Assert.AreEqual(articulos, articulos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Articulos>();
            lista = ArticulosBLL.GetList(p => true);

            Assert.AreEqual(lista, lista);
        }


    }
}