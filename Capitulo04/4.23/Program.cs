/*
 * Utilizando una metodología similar a la del ejercicio 4.21, encuentre los dos valores más grandes de los 10 que
se introdujeron. [Nota: puede introducir cada número sólo una vez].
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int mayor = int.MinValue;
            int segundoMayor = int.MinValue;

            while (contador < 10)
            {
                contador++;
                Console.WriteLine("{0}{1}", "Ingrese el número ", contador);
                int numero = int.Parse(Console.ReadLine());

                
                //En caso de que solo haya entrado un primer número
                if (contador == 1)
                {
                    mayor = numero;
                    Console.WriteLine("El número mayor hasta ahora es: {0}", mayor);
                }
                else// En caso de que el contador sea 2 en adelante
                {
                    if (numero > mayor)
                    {
                        segundoMayor = mayor;
                        mayor = numero;
                    }
                    else if(numero > segundoMayor)
                    {
                        segundoMayor = numero;
                    }

                    Console.WriteLine("El número mayor hasta ahora es: {0}", mayor);
                    Console.WriteLine("El segundo número mayor hasta ahora es: {0}", segundoMayor);
                }

            }
        }
    }
}
