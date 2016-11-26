using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculos = new Calculos();

            Console.WriteLine("Ingrese ún número entero:");
            calculos.valorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese ún número entero:");
            calculos.valorB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese ún número entero:");
            calculos.valorC = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los enteros es: {0}\nEl promedio es: {1}\nEl producto: {2}\nEl menor: {3}\nY el mayor: {4}",
                calculos.suma(), calculos.promedio(), calculos.producto(), calculos.menor(), calculos.mayor());
        }
    }
}
