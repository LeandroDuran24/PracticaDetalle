using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotizacion
{
    public class Utilidades
    {
        public static int TOINT(string nombre)
        {
            int num;
            int.TryParse(nombre, out num);
            return num; 
        }
    }
}
