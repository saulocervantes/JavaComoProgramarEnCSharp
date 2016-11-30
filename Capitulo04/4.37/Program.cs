/*
 * Una compañía desea transmitir datos a través del teléfono, pero le preocupa que sus teléfonos puedan estar
intervenidos. Le ha pedido a usted que escriba un programa que cifre sus datos, de manera que éstos puedan transmitirse
con más seguridad. Todos los datos se transmiten como enteros de cuatro dígitos. Su aplicación debe leer un
entero de cuatro dígitos introducido por el usuario y cifrarlo de la siguiente manera: reemplace cada dígito con el
resultado de sumar 7 al dígito y obtener el residuo después de dividir el nuevo valor entre 10. Luego intercambie
el primer dígito con el tercero, e intercambie el segundo dígito con el cuarto. Después imprima el entero cifrado.
Escriba una aplicación separada que reciba como entrada un entero de cuatro dígitos cifrado, y que lo descifre para
formar el número original.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._37
{
    class Program
    {
        static void Main(string[] args)
        {

            // Recibo entero
            Console.WriteLine("Escriba un número entero de 4 dígitos:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Creo objeto
            Entero entero = new Entero();

            entero.SepararDigitos(numero);
            entero.Cifrar();

            Console.WriteLine("Ingrese un entero para decifrarlo");
            numero = int.Parse(Console.ReadLine());

            entero.SepararDigitos(numero);
            entero.Descifrar();
        }
    }
}
