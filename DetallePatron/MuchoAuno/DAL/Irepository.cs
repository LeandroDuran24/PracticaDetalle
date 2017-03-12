using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MuchoAuno.DAL
{
   public  interface Irepository <TEntity>: IDisposable where TEntity:class
   {
        TEntity Guardar(TEntity criterio);
        bool Mdificar (TEntity criterio);
        bool Eliminar(TEntity criterio);
        TEntity Buscar(Expression<Func<TEntity, bool>>criterio);
        List<TEntity> GetListTodo();
        List<TEntity> GEtList(Expression<Func<TEntity, bool>> criterio);
   }
    
}
