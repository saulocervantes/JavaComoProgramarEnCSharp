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
            float lado1 = 0;
            float lado2 = 0;
            float lado3 = 0;
            int i = 0;

            while (i < 3)
            {
                ++i;
                Console.WriteLine("Ingrese el tamaño del lado{0} del triángulo:", i);
                float numero = float.Parse(Console.ReadLine());

                if (i == 1)
                    lado1 = numero;
                if (i == 2)
                    lado2 = numero;
                if (i == 3)
                    lado3 = numero;
            }

            if (lado1 > 0 & lado2 > 0 & lado3 > 0)
            {
                Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
                triangulo.VerificarTriangulo();
            }
            else
            {
                Console.WriteLine("Todos los valores deben ser mayor a 0.");
            }
            


        }
    }
}
