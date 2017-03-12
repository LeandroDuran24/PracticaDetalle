using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Cotizacion.Entidades;

namespace Cotizacion.BLL
{
   public  class ClienteBLL
    {
        public static bool Guardar(Clientes nuevo)
        {
            bool result = false;
            using (var db = new DAL.Repositorio<Clientes>())
            {
                result = db.Guardar(nuevo) != null;
            }
            return result;
        }

        public static List<Clientes> GetListTodo()
        {
            List<Clientes> list = null;
            using (var db = new DAL.Repositorio<Clientes>())
            {
                try
                {
                    list = db.GetListTodo();
                }
                catch (Exception)
                {

                    throw;
                }
                return list;
            }

        }

        public static List<Entidades.Clientes> GetList(Expression<Func<Clientes, bool>> criterio)
        {
            List<Clientes> list = null;
            using (var db = new DAL.Repositorio<Clientes>())
            {
                try
                {
                    list = db.GetList(criterio).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return list;
            }
        }
    }
}
