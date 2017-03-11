using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Detalle.Entidades
{
   public class Materias
    {
        [Key]
        public int MateriaId { get; set; }
        public string Nombre { get; set; }

        public Materias()
        {
            this.EstudianteList = new List<Estudiantes>();
        }

        public virtual List<Estudiantes> EstudianteList { get; set; }
        
    }
}

