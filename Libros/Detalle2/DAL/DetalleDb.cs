using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Detalle2.Entidades;

namespace Detalle2.DAL
{
    public class DetalleDb:DbContext
    {
        public DetalleDb():base("ConStr")
        {

        }
        public DbSet<Libros> libros  { get; set; }
        public DbSet <Autores> autores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autores>()
            .HasMany(p => p.librosList)
            .WithMany(p => p.autoresList)
            .Map(mapeo =>
            {
                mapeo.MapLeftKey ("LibrosId");
                mapeo.MapRightKey  ("AutoresId");
                mapeo.ToTable ( "LibroAutore");
            });
           
        }


    }
}
