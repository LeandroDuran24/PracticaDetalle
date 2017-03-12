using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Cotizacion.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string  Nombre { get; set; }
        public string Direccion { get; set; }
        public string Producto { get; set; }
        public int ProductoId { get; set; }

        public virtual List<Produtos>productoList { get; set; }
        public Clientes()
        {
            this.productoList = new List<Produtos>();
        }
    }
}
