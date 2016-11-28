/*
 Escriba una aplicación en Java que utilice ciclos para imprimir la siguiente tabla de valores:
N   10*N    100*N   1000*N
1   10      100     1000
2   20      200     2000
3   30      300     3000
4   40      400     4000
5   50      500     5000
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N   10*N    100*N   1000*N");

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("{0,-4}{1,-8}{2,-8}{3,3}", i, 10 * i, 100 * i, 1000 * i);
                ++i;
            }
        }
    }
}
