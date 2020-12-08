using Microsoft.VisualStudio.TestTools.UnitTesting;
using FotoStudio.BLL;
using FotoStudio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotoStudio.BLL.Tests
{
    [TestClass()]
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Cliente clientes = new Cliente
            {
                ClienteId = 0,
                UsuarioId = 1,
                Nombres = "Frandy Francisco",
                Apellidos = "Mota",
                Cedula = "40214324567",
                Direccion = "Su Casa",
                Telefono = "123123123",
                Celular = "909808080",
                Sexo = "Hombre",
                FechaNacimiento = DateTime.Now
            };
            paso = ClienteBLL.Guardar(clientes);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = ClienteBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Cliente clientes;
            clientes = ClienteBLL.Buscar(1);

            Assert.AreEqual(clientes, clientes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Cliente>();
            lista = ClienteBLL.GetList(p => true);

            Assert.AreEqual(lista, lista);
        }



    }
}