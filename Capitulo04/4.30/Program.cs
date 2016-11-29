/*
 * (Palíndromos) Un palíndromo es una secuencia de caracteres que se lee igual al derecho y al revés. Por ejemplo,
cada uno de los siguientes enteros de cinco dígitos es un palíndromo: 12321, 55555, 45554 y 11611. Escriba una
aplicación que lea un entero de cinco dígitos y determine si es un palíndromo. Si el número no es de cinco dígitos, el
programa debe mostrar un mensaje de error y permitir al usuario que introduzca un nuevo valor.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número de 5 dígitos:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Validar que sea de  digitos
            while(numero / 100000 > 0 || (double)numero / 100000 < 0.1)
            {
                Console.WriteLine("El número que ingreso no es de 5 digitos.");
                Console.WriteLine("Ingrese un número de 5 digitos:");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            // Separar en digitos
            int posicion1 = numero / 10000;
            int posicion2 = numero / 1000 % 10;
            int posicion3 = numero / 100 % 10;
            int posicion4 = numero / 10 % 10;
            int posicion5 = numero % 10;

            Console.WriteLine("{0} {1} {2} {3} {4}", posicion1, posicion2, posicion3, posicion4, posicion5);

            // Determinar si es o no un palindromo
            if (posicion1 == posicion5 & posicion2 == posicion4)
                Console.WriteLine("El número {0} SI es un palíndromo", numero);
            else
                Console.WriteLine("El número {0} NO es un palíndromo", numero);

        }
    }
}
