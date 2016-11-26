using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;

            Console.WriteLine("Ingrese un número entero:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un número entero:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número entero:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un número entero:");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número entero:");
            e = Convert.ToInt32(Console.ReadLine());

            var comparacion = new Comparacion(a, b, c, d, e);

            Console.WriteLine("El número mayor es {0} y el menor {1}", comparacion.mayor(), comparacion.menor());
        }
    }
}
