using Detalle.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Detalle.BLL
{
   public class EstudianteBLL
    {
        public static bool Guardar(Entidades.Estudiantes n)
        {
            bool retono = false;
            using (var db = new DataDb())
            {
                try
                {

                    foreach(var g in n.MateriaList)
                    {
                        db.Entry(g).State = System.Data.Entity.EntityState.Unchanged;
                    }
                 
                if(Buscar(n.EstudianteId)==null)
                    {
                        db.EstudiantesDb.Add(n);
                        db.SaveChanges();
                        retono = true;
                    }
                    else
                    {
                        db.Entry(n).State = System.Data.Entity.EntityState.Unchanged;
                        retono = true;

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return retono;
        }

        public static Entidades.Estudiantes Buscar(int id)
        {

            Entidades.Estudiantes nuevo;
            using (var db = new DataDb())
            {
                try
                {
                    nuevo = db.EstudiantesDb.Find(id);

                }
                catch (Exception)
                {

                    throw;
                }
                return nuevo;
            }
        }

        public static bool Eliminar(Entidades.Estudiantes id)
        {
            using (var db = new DataDb())
            {
                try
                {
                    db.Entry(id).State = System.Data.Entity.EntityState.Deleted;
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Entidades.Estudiantes> GetListodo()
        {
            List<Entidades.Estudiantes> lista = new List<Entidades.Estudiantes>();
            using (var db = new DataDb())
            {
                try
                {
                    lista = db.EstudiantesDb.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Entidades.Estudiantes> GetListNombre(string nombre)
        {
            List<Entidades.Estudiantes> lista = new List<Entidades.Estudiantes>();
            using (var db = new DataDb())
            {
                try
                {
                    lista = db.EstudiantesDb.Where(p => p.Nombre == nombre).ToList();
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
