using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MuchoAuno.Entidades;

namespace MuchoAuno.DAL
{
    class DetalleDb:DbContext
    {
        public DetalleDb() : base("ConStr")
        {

        }
        public DbSet<Libros> libros { get; set; }
        public DbSet<Autores> autores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autores>()
            .HasMany(p => p.librosList)
            .WithMany(p => p.autorList)
            .Map(mapeo =>
            {
                mapeo.MapLeftKey("LibrosId");
                mapeo.MapRightKey("AutoresId");
                mapeo.ToTable("LibroAutore");
            });

        }


    }
}
