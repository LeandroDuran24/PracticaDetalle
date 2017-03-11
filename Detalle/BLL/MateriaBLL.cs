using Detalle.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Detalle.BLL
{
   public class MateriaBLL
    {
       public static bool Guardar(Entidades.Materias nueva)
        {
            bool retorno = false;
            using (var db = new DataDb())
            {
                try
                {
                    if(Buscar(nueva.MateriaId )==null)
                    {
                        db.MateriaDb.Add(nueva);
                        db.SaveChanges();
                        retorno = true;
                    }else
                    {
                        db.Entry(nueva).State = EntityState.Unchanged;
                        retorno = true;
                    }
                    
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return retorno;
        }

        public static Entidades.Materias Buscar(int id)
        {
            var nuevo = new Entidades.Materias();
            using (var db = new DataDb())
            {
                try
                {
                    nuevo = db.MateriaDb.Find(id);
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return nuevo;
        }


        public static List<Entidades.Materias> GetListodo()
        {
            List<Entidades.Materias> lista = new List<Entidades.Materias>();
            using (var db = new DataDb())
            {
                try
                {
                    lista = db.MateriaDb.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }


    }
}
