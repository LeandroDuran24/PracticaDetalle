using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MuchoAuno.DAL
{
    public class Repositorio<TEntity> : Irepository<TEntity> where TEntity : class
    {

        DetalleDb context = null;
        public Repositorio()
        {
            context = new DetalleDb();
        }

        public DbSet<TEntity>EntitSet
        {
            get {
                return context.Set<TEntity>();
            }
        }


        public TEntity Buscar(Expression<Func<TEntity, bool>> criterio)
        {
            TEntity result = null;

            try
            {
                result =EntitSet.FirstOrDefault(criterio);
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

        public bool Eliminar(TEntity criterio)
        {
            bool result = false;
            try
            {
                EntitSet.Attach(criterio);
                EntitSet.Remove(criterio);
                result = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<TEntity> GEtList(Expression<Func<TEntity, bool>> criterio)
        {
            try
            {
                return EntitSet.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitSet.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public TEntity Guardar(TEntity criterio)
        {
            TEntity result = null;

            try
            {
                EntitSet.Add(criterio);
                context.SaveChanges();
                result = criterio;
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }

        public bool Mdificar(TEntity criterio)
        {
            bool result = false;
            try
            {
                EntitSet.Attach(criterio);
                context.Entry(criterio).State = EntityState.Modified;
                result = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
