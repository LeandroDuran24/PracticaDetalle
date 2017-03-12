using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using MuchoAuno.DAL;
using MuchoAuno.Entidades;

namespace MuchoAuno.BLL
{
    public class AutoreBLL
    {
        public static bool Guardar(Autores nuevo)
        {
            bool result = false;

            using (var conn = new Repositorio<Autores>())
            {
                try
                {
                    result = conn.Guardar(nuevo) != null;
                }
                catch (Exception)
                {

                    throw;
                }
                return result;
            }
        }

            public static List<Entidades.Autores> GetLisTodo()
        {
            List<Entidades.Autores> list = null;
            using (var db = new Repositorio<Autores>())
            {
                try
                {
                    list = db.GetListTodo();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return list;
        }

        public static List<Entidades.Autores>GetList(Expression<Func<Autores,bool>>criterio)
        {
            List<Entidades.Autores> list = null;
            using (var db = new Repositorio<Autores>())
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

