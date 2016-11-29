/*
 * Escriba una aplicación que lea tres valores distintos de cero introducidos por el usuario, y que determine e
imprima si podrían representar los lados de un triángulo.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35
{
    class Program
    {
        static void Main(string[] args)
        {
            float cateto1 = float.MinValue;
            float cateto2 = float.MinValue;
            float hipotenusa = float.MinValue;
            int i = 0;

            while (i < 3)
            {
                ++i;
                Console.WriteLine("Ingrese el tamaño del lado{0} del triángulo:", i);
                float numero = float.Parse(Console.ReadLine());

                if (i == 1)
                    hipotenusa = numero;
                else if (i == 2)
                {
                    cateto1 = Math.Min(hipotenusa, numero);
                    hipotenusa = Math.Max(hipotenusa, numero);
                }
                else
                {
                    cateto2 = Math.Min(hipotenusa, numero);
                    hipotenusa = Math.Max(hipotenusa, numero);
                }

            }
            
            Triangulo triangulo = new Triangulo(cateto1, cateto2, hipotenusa);
            triangulo.VerificarTriangulo();


        }
    }
}
