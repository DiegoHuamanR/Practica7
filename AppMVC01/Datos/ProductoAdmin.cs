using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC01.Models;


namespace AppMVC01.Datos
{
    public class ProductoAdmin
    {
        public IEnumerable<PRODUCTO> Consultar()
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.PRODUCTO.AsNoTracking().ToList();
            }
        }
        public PRODUCTO Consultar(int id)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.PRODUCTO.AsNoTracking().FirstOrDefault(c =>
               c.codProducto == id);
            }
        }
        public void Guardar(PRODUCTO modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.PRODUCTO.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(PRODUCTO modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(PRODUCTO modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}