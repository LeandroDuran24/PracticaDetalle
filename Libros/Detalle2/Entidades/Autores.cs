using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Detalle2.Entidades
{
    public class Autores
    {
        [Key]
        public int AutoresId { get; set; }
        public string Nombre { get; set; }

        public virtual List<Libros>librosList { get; set; }
        public Autores()
        {
            this.librosList = new List<Libros>();
        }
    }
}
