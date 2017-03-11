using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Detalle2.DAL;
using Detalle2.Entidades;

namespace Detalle2.BLL
{
    public class AutoresBLL
    {
        public static bool Guardar(Autores nuevo)
        {
            using (var db = new DetalleDb())
            {
                try
                { 

                    if (Buscar(nuevo.AutoresId)==null)
                   {
                        db.autores.Add(nuevo);
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

        public static Autores Buscar(int autor)
        {
            var busca = new Autores();
            using (var db = new DetalleDb())
            {
                try
                {
                    busca = db.autores.Find(autor);
                 
                    
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

        public static List<Autores>GetListTodo()
        {
            List<Autores> lista = new List<Autores>();
            using (var db = new DetalleDb())
            {
                try
                {
                    lista = db.autores.ToList();
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
