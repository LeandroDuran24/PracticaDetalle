using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Detalle
{
   public class Utilidades
    {
        public static int TOIN(string nombre)
        {
            int numero ;
            int.TryParse(nombre, out numero);
            return numero;

        }
    }
}
