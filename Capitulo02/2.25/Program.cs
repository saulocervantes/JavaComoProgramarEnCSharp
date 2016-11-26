using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un entero");
            int entero = Convert.ToInt32(Console.ReadLine());

            if (entero % 2 == 0)
            {
                Console.WriteLine("{0} es un número par.", entero);
            }
            else
            {
                Console.WriteLine("{0} es un número impar.", entero);
            }
        }
    }
}
