/*
 El proceso de encontrar el valor más grande (es decir, el máximo de un grupo de valores) se utiliza frecuentemente
en aplicaciones de computadora. Por ejemplo, un programa para determinar el ganador de un concurso de
ventas recibe como entrada el número de unidades vendidas por cada vendedor. El vendedor que haya vendido más
unidades es el que gana el concurso. Escriba un programa en seudocódigo y después una aplicación en Java que reciba
como entrada una serie de 10 números enteros, y que determine e imprima el mayor de los números. Su programa debe
utilizar cuando menos las siguientes tres variables:
a) contador: un contador para contar hasta 10 (es decir, para llevar el registro de cuántos números se han
introducido, y para determinar cuando se hayan procesado los 10 números).
b) numero: el entero más reciente introducido por el usuario.
c) mayor: el número más grande encontrado hasta ahora.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int mayor = int.MinValue;

            while ( contador < 10)
            {
                contador++;
                Console.WriteLine("{0}{1}","Ingrese el número ", contador);
                int numero = int.Parse(Console.ReadLine());

                mayor = Math.Max(numero,mayor);

                Console.WriteLine("El número mayor hasta ahora es: {0}", mayor);
            }
        }
    }
}
