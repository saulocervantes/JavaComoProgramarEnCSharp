/*
 *Escriba una aplicación que pida al usuario que introduzca el tamaño del lado de un cuadrado y que muestre un
cuadrado hueco de ese tamaño, compuesto de asteriscos. Su programa debe funcionar con cuadrados que tengan lados
de todas las longitudes entre 1 y 20. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();

            Console.WriteLine("Introduzca el tamaño del cuadrado:");
            cuadrado.Lado = Convert.ToInt32( Console.ReadLine() );

            cuadrado.Dibujar();
        }
    }
}
