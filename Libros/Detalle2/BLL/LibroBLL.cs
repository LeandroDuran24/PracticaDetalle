using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Detalle2.DAL;
using Detalle2.Entidades;

namespace Detalle2.BLL
{
    public class LibroBLL
    {
        public static bool Guardar(Libros nuevo)
        {
            using (var db = new DetalleDb())
            {
                try
                {
                   /*foreach(var g in nuevo.autoresList)
                    {
                        db.Entry(g).State = System.Data.Entity.EntityState.Unchanged;
                    */
                    
                    if (Buscar(nuevo.LibrosId) == null)
                    {
                        db.libros.Add(nuevo);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        db.Entry(nuevo).State = System.Data.Entity.EntityState.Unchanged;
                        db.SaveChanges();
                        return true;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                return false;
            }
        }

        public static Libros Buscar(int autor)
        {
            var busca = new Libros();
            using (var db = new DetalleDb())
            {
                try
                {
                    busca = db.libros.Find(autor);
               

                }
                catch (Exception)
                {

                    throw;
                }
                return busca;
            }
        }

        public static bool Eliminar(Autores autor)
        {
            using (var db = new DetalleDb())
            {
                try
                {
                    db.Entry(autor).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
                return false;
            }
        }

        public static List<Libros> GetListTodo()
        {
            List<Libros> lista = new List<Libros>();
            using (var db = new DetalleDb())
            {
                try
                {
                    lista = db.libros.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return lista;
            }
        }

        public static List<Libros>GetListNombre(string nombre)
        {
            List<Libros> lista = new List<Libros>();
            using (var db = new DetalleDb())
            {
                try
                {
                    lista = db.libros.Where(p => p.Nombre == nombre).ToList();
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
