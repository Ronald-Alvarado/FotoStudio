using Microsoft.VisualStudio.TestTools.UnitTesting;
using FotoStudio.BLL;
using FotoStudio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotoStudio.BLL.Tests
{
    [TestClass()]
    public class CategoriasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Categoria categorias = new Categoria();
            categorias.CategoriaId = 0;
            categorias.UsuarioId = 1;
            categorias.Nombre = "Ceriografia";

            paso = CategoriaBLL.Guardar(categorias);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = CategoriaBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Categoria categorias;
            categorias = CategoriaBLL.Buscar(1);

            Assert.AreEqual(categorias, categorias);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Categoria>();
            lista = CategoriaBLL.GetList(p => true);

            Assert.AreEqual(lista, lista);
        }
    }
}