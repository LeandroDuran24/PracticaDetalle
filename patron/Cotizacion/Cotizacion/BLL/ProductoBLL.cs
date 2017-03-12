using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Cotizacion.Entidades;

namespace Cotizacion.BLL
{
    public class ProductoBLL
    {
        public static bool Guardar(Produtos nuevo)
        {
            bool result = false;
            using (var db = new DAL.Repositorio<Produtos>())
            {
                try
                {
                    result = db.Guardar(nuevo) != null;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return result;
        }

        public static List<Produtos> GetListTodo()
        {
            List<Produtos> list = null;
            using (var db = new DAL.Repositorio<Produtos>())
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

        public  static List<Entidades.Produtos>GetList(Expression<Func<Produtos,bool>>criterio)
        {
            List<Produtos> list = null;
            using (var db = new DAL.Repositorio<Produtos>())
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
