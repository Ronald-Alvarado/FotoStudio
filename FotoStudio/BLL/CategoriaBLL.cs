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
    public class CategoriaBLL
    {
        public static bool Guardar(Categoria categorias)
        {
            if (!Existe(categorias.CategoriaId))
            {
                return Insertar(categorias);
            }
            else
            {
                return Modificar(categorias);
            }

        }

        public static bool Insertar(Categoria categorias)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (db.Categoria.Add(categorias) != null)
                {
                    paso = (db.SaveChanges() > 0);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Categoria categorias)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Entry(categorias).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch
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
                encontrado = db.Categoria.Any(d => d.CategoriaId == id);
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
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                var eliminar = db.Categoria.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Categoria Buscar(int id)
        {
            Contexto db = new Contexto();
            Categoria categorias = new Categoria();

            try
            {
                categorias = db.Categoria.Find(id);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return categorias;
        }

        public static List<Categoria> GetList(Expression<Func<Categoria, bool>> categorias)
        {
            Contexto db = new Contexto();
            List<Categoria> listado = new List<Categoria>();

            try
            {
                listado = db.Categoria.Where(categorias).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return listado;
        }
    }
}
