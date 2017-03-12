using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Cotizacion.DAL
{
    public class DetalleDb : DbContext
    {
        public DetalleDb() : base("ConStr")
        {

        }
        public DbSet<Entidades.Clientes> cliente { get; set; }
        public DbSet<Entidades.Produtos> producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Produtos>()
            .HasMany(p => p.clienteList)
            .WithMany(p => p.productoList)
            .Map(mapeo =>
                {
                    mapeo.MapLeftKey("ProductoId");
                    mapeo.MapRightKey("ClienteId");
                    mapeo.ToTable("ClienteProductos");
                });
        }
    }
}
