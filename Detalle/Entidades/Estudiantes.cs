using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Detalle.Entidades
{
   public class Estudiantes
    {

        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int MateriaId { get; set; }
        public string Materia { get; set; }

        public Estudiantes()
        {
            this.MateriaList = new List<Materias>();
        }

        public virtual List<Materias> MateriaList { get; set; }



    }
}




