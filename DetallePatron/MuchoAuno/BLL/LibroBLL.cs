using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using MuchoAuno.DAL;
using MuchoAuno.Entidades;

namespace MuchoAuno.BLL
{
   public  class LibroBLL
    {
        public static bool Guardar(Libros nuevo)
        {
            bool result = false;

            using (var db = new Repositorio<Libros>())
            {
                try
                {
                    result = db.Guardar(nuevo) != null;
                }
                catch (Exception)
                {

                    throw;
                }
                return result;
            }
        }

        public static List<Libros>getListTodo()
        {
            List<Entidades.Libros> lista = null;
            using (var db = new Repositorio<Libros>())
            {
                try
                {
                    lista = db.GetListTodo();
                }
                catch (Exception)
                {

                    throw;
                }
               
            }
            return lista;
        }

        public static List<Entidades.Libros>GetList(Expression<Func< Libros, bool>> criterio)
        {
            List<Libros> list = null;

            using (var db = new Repositorio<Libros>())
            {
                try
                {
                    list = db.GEtList(criterio).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return list;

        }
    }
}
