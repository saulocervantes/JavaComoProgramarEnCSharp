using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Fecha fecha1 = new Fecha(06,08,2005);
            var fecha2 = new Fecha(05,01,1991);

            fecha1.mostrarFecha();
            fecha2.mostrarFecha();
        }
    }
}
