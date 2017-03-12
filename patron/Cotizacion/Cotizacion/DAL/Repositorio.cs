using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cotizacion.DAL
{
    class Repositorio<Tentity> : IRepository<Tentity> where Tentity : class
    {
        DetalleDb context = null;

        public Repositorio()
        {
            context = new DetalleDb();
        }

        public DbSet<Tentity>EntitySet
        {
            get
            {
                return context.Set<Tentity>();
            }
        }

        public Tentity Buscar(Expression<Func<Tentity, bool>> criterio)
        {
            Tentity result = null;

            try
            {
                result=EntitySet.FirstOrDefault(criterio);
                
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public void Dispose()
        {
            if(context!=null)
            {
                context.Dispose();
            }
        }

        public bool Eliminar(Tentity criterio)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(criterio);
                EntitySet.Remove(criterio);
                result = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<Tentity> GetList(Expression<Func<Tentity, bool>> criterio)
        {
            try
            {
                return EntitySet.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Tentity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Tentity Guardar(Tentity criterio)
        {
            Tentity result = null;
            try
            {
                EntitySet.Add(criterio);
                context.SaveChanges();
                result = criterio;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Modificar(Tentity criterio)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(criterio);
                EntitySet.Remove(criterio);
                result=context.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
