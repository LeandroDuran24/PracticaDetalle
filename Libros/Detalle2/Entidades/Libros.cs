using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Detalle2.Entidades
{
   public  class Libros
    {
        [Key]
        public int LibrosId { get; set; }
        public string Nombre { get; set; }
        public int Edicion { get; set; }
        public string Autores { get; set; }
        public int AutoresId { get; set; }

        public virtual List<Autores>autoresList { get; set; }

        public Libros()
        {
            autoresList = new List<Entidades.Autores>();
        }


    }
}
