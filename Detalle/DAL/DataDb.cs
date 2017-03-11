using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Detalle.DAL
{
    public class DataDb : DbContext
    {

        public DataDb() : base("ConStr")
        {

        }

        public DbSet<Entidades.Estudiantes> EstudiantesDb { get; set; }
        public DbSet<Entidades.Materias> MateriaDb { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Materias>()
             .HasMany(mat => mat.EstudianteList)
             .WithMany(est => est.MateriaList)
             .Map(mapa =>

             {
                 mapa.MapLeftKey("MateriaId");
                 mapa.MapRightKey("EstudianteId");
                 mapa.ToTable("EstudianteMateria");
             });
        }
    }
}

