using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un entero de 5 digitos");
            int num = int.Parse(Console.ReadLine());

            //12345
            Console.WriteLine("{0} {1} {2} {3} {4}", num % 100000 / 10000, num % 10000 / 1000, num % 1000 / 100, num % 100 / 10, num % 10);// Operadores de izquierda a derecha
            Console.WriteLine(num);

        }
    }
}
