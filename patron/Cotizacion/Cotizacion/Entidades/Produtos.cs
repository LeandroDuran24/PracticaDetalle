using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Cotizacion.Entidades
{
   public class Produtos
    {
       [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }

        public virtual List<Clientes>clienteList { get; set; }

        public Produtos()
        {
            this.clienteList = new List<Clientes>();
        }

    }
}
