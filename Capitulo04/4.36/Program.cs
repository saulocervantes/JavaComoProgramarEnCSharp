/*
 * Escriba una aplicación que lea tres enteros distintos de cero, determine e imprima si estos enteros podrían
representar los lados de un triángulo rectángulo.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._36
{
    class Program
    {
        static void Main(string[] args)
        {
            int cateto1 = 0;
            int cateto2 = 0;
            int hipotenusa = 0;
            int i = 0;

            while (i < 3)
            {
                ++i;
                Console.WriteLine("Ingrese el tamaño del lado{0} del triángulo:", i);
                int numero = int.Parse(Console.ReadLine());

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

            if(cateto1 != 0 & cateto2 != 0 & hipotenusa != 0)
            {
                TrianguloRectangulo triangulo = new TrianguloRectangulo(cateto1, cateto2, hipotenusa);
                triangulo.VerificarTriangulo();
            }
            else
            {
                Console.WriteLine("Los lados deben ser mayores a cero.");
            }
                
            
        }
    }
}
