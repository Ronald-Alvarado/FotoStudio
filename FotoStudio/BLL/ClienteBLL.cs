using System;
using FotoStudio.DAL;
using FotoStudio.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FotoStudio.BLL
{
    public class ClienteBLL
    {
        public static bool Guardar(Cliente clientes)
        {
            if (!Existe(clientes.ClienteId))
            {
                return Insertar(clientes);
            }
            else
            {
                return Modificar(clientes);
            }

        }

        public static bool Insertar(Cliente cliente)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Cliente.Add(cliente) != null)
                    paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Cliente cliente)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(cliente).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        private static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Cliente.Any(d => d.ClienteId == id);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Cliente.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Cliente Buscar(int id)
        {
            Cliente cliente = new Cliente();
            Contexto db = new Contexto();

            try
            {
                cliente = db.Cliente.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return cliente;
        }

        public static List<Cliente> GetList(Expression<Func<Cliente, bool>> cliente)
        {
            List<Cliente> Lista = new List<Cliente>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Cliente.Where(cliente).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

        public static String ObtenerNombre(int id)
        {
            Cliente cliente = Buscar(id);
            if (cliente == null)
                return "No existe el cliente";
            else
                return cliente.Nombres;
        }

        public static String ObtenerApellido(int id)
        {
            Cliente cliente = Buscar(id);
            if (cliente == null)
                return "No existe el cliente";
            else
                return cliente.Apellidos; ;
        }
    }
}
