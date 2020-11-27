﻿using FotoStudio.DAL;
using FotoStudio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FotoStudio.BLL
{
    public class VentaBLL
    {
        public static bool Guardar(Venta ventas)
        {
            if (!Existe(ventas.VentaId))
            {
                return Insertar(ventas);
            }
            else
            {
                return Modificar(ventas);
            }

        }

        public static bool Insertar(Venta venta)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Venta.Add(venta) != null)
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

        public static bool Modificar(Venta venta)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Database.ExecuteSqlRaw($"Delete FROM VentasDetalle Where VentasId={venta.VentaId}");
                foreach (var item in venta.VentasDetalle)
                {
                    db.Entry(item).State = EntityState.Added;
                }
                db.Entry(venta).State = EntityState.Modified;
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

        public static Venta Buscar(int id)
        {
            Venta venta = new Venta();
            Contexto db = new Contexto();

            try
            {
                venta = db.Venta.Include(x => x.VentasDetalle).Where(x => x.VentaId == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return venta;
        }

        private static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Venta.Any(d => d.VentaId == id);
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
                var eliminar = VentaBLL.Buscar(id);
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

        public static List<Venta> GetList(Expression<Func<Venta, bool>> venta)
        {
            List<Venta> Lista = new List<Venta>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Venta.Where(venta).ToList();
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
    }
}