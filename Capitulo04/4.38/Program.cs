/*
 * El factorial de un entero n no negativo se escribe como n! y se define de la siguiente manera:
n! = n · (n – 1) · (n – 2) · ... · 1 (para valores de n mayores o iguales a 1)
y
n! = 1 (para n = 0)
Por ejemplo, 5! = 5 · 4 · 3 · 2 · 1, que es 120.
a) Escriba una aplicación que lea un entero no negativo, y calcule e imprima su factorial.
b) Escriba una aplicación que estime el valor de la constante matemática e, utilizando la fórmula
e = 1 + 1/1! + 1/2! + 1/3! + ....
c) Escriba una aplicación que calcule el valor de e^x, utilizando la fórmula
e^x = 1 + x^1/1! + x^2/2! + x^3/3! + ...
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._38
{
    class Program
    {
        static void Main(string[] args)
        {
            // a)
            Factorial factorial = new Factorial();
            Console.WriteLine(factorial.CalcularFactorial(5));

            // b)
            ConstanteE e = new ConstanteE();
            Console.WriteLine("e = {0}", e.Calcular());
            Console.WriteLine("e = {0}", Math.E);

            // c)
            Console.WriteLine("Ingrese el el valor de x para e^x:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("e^{0} ~ {1,8:f}", numero, Euler(numero));

        }

        static double Euler(int x)
        {
            // e^x = x^0/0! + x^1/1! + x^2/2! + x^3/3! 
            double resultado = 0;
            ConstanteE e = new ConstanteE();

            resultado = Math.Pow(Math.E, x);
            resultado = Math.Pow(e.Calcular(), x);

            // Usando While
            // Esta forma es muy imprecisa
            int i = 0;
            Factorial factorial = new Factorial();
            resultado = 0;

            while (i < 13)
            {
                resultado += Math.Pow(x, i)/factorial.CalcularFactorial(i);
                ++i;
            }

            return resultado;
        }
    }
}
