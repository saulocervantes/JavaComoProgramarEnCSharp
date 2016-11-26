using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}{1,9}{2,5}", "numero", "cuadrado", "cubo");

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0,-7}{1,-9}{2}", i, i * i, i * i * i);
            }
        }
    }
}
