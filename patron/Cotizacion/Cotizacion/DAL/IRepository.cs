using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cotizacion.DAL
{
    public interface IRepository <Tentity>:IDisposable where Tentity:class
    {
        Tentity Guardar(Tentity criterio);
        bool Eliminar(Tentity criterio);
        bool Modificar(Tentity criterio);
        Tentity Buscar(Expression<Func<Tentity, bool>> criterio);
        List<Tentity> GetList(Expression<Func<Tentity, bool>> criterio);
        List<Tentity> GetListTodo();

    }
}
