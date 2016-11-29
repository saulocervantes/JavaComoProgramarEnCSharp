/*
 * Escriba una aplicación que utilice sólo las instrucciones de salida
System.out.print( "* " );
System.out.print( " " );
System.out.println();
para mostrar el patrón de tablero de damas que se muestra a continuación. Observe que una llamada al método System.
out.println sin argumentos hace que el programa imprima un solo carácter de nueva línea. [Sugerencia: se
requieren estructuras de repetición].
* * * * * * * *
 * * * * * * * *
* * * * * * * *
 * * * * * * * *
* * * * * * * *
 * * * * * * * *
* * * * * * * *
 * * * * * * * *

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._32
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int impar = 1;

            while (i < 8)
            {
                while (j < 8)
                {
                    Console.Write("* ");
                    ++j;
                }
                impar *= -1;
                Console.WriteLine();
                Console.Write(impar < 0 ? " " : "");
                j = 0;
                i++;
            }
        }
    }
}
