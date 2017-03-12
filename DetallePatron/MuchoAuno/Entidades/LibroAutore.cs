using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MuchoAuno.Entidades
{
    public class LibroAutore
    {   
        [Key]
        public int libroAutoreId { get; set; }
        public int LibrosId { get; set; }
        public int ActoresId { get; set; }

        

    }
}
