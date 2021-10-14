using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC01.Models;
namespace AppMVC01.Datos
{
    public class CustomerAdmin
    {
        public IEnumerable<CLIENTES> Consultar()
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.CLIENTES.AsNoTracking().ToList();
            }
        }
        public CLIENTES Consultar(int id)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                return contexto.CLIENTES.AsNoTracking().FirstOrDefault(c =>
               c.codigo == id);
            }
        }
        public void Guardar(CLIENTES modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.CLIENTES.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(CLIENTES modelo)
        {
            using (VENTASEntities1 contexto = new VENTASEntities1())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(CLIENTES modelo)
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
